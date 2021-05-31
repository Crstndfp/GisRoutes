using Assets.Dto;
using Assets.Utilities;
using BussinesLogic.Utilities;
using Repository.DomCemaco;
using Repository.Stream;
using Repository.Wms3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussinesLogic.ShippingOrder
{
    public class ShippingOrder
    {
        private readonly ShippingOrderRepository shippingOrderRepository;
        private readonly PreOrdersRepository preOrdersRepository;
        private readonly DepartmentRepository departmentRepository;
        private readonly FileRepository fileRepository;
        private readonly TransportRepository transportRepository;
        private readonly ReadAppSettings readAppSettings;

        public ShippingOrder
            (
            ShippingOrderRepository shippingOrderRepository,
            PreOrdersRepository preOrdersRepository,
            DepartmentRepository departmentRepository,
            FileRepository fileRepository,
            TransportRepository transportRepository,
            ReadAppSettings readAppSettings
            )
        {
            this.shippingOrderRepository = shippingOrderRepository;
            this.preOrdersRepository = preOrdersRepository;
            this.departmentRepository = departmentRepository;
            this.fileRepository = fileRepository;
            this.transportRepository = transportRepository;
            this.readAppSettings = readAppSettings;
        }

        public async Task<IEnumerable<ShippingDto>> GetOrderShipping(DateTime day, string company)
        {
            if (company.Equals(Const.STRD))
            {
                return await GetGisOrder(day);
            }
            else
            {
                return await GetOrdersLec(day, company);
            }
        }

        /// <summary>
        /// Get orders the different transpot configured
        /// </summary>
        /// <param name="day"></param>
        /// <param name="codTransport"></param>
        /// <returns></returns>
        private async Task<IEnumerable<ShippingDto>> GetOrdersLec(DateTime day, string codTransport)
        {
            IEnumerable<ShippingDto> listWithoutVerified
                = await preOrdersRepository.GetPreOrderShipping(day, codTransport);
            return UpdateGeolocation(listWithoutVerified);
        }

        /// <summary>
        /// Get orders shipping for GisRoutes Cemaco
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        private async Task<IEnumerable<ShippingDto>> GetGisOrder(DateTime day)
        {
            IEnumerable<ShippingDto> listVerified = new List<ShippingDto>();
            IEnumerable<ShippingDto> listWithoutVerified = new List<ShippingDto>();
            Task<IEnumerable<ShippingDto>> taskVerified =
                shippingOrderRepository.GetOrderShipping(day);
            Task<IEnumerable<ShippingDto>> taskWithoutVerified =
                preOrdersRepository.GetPreOrderShipping(day, Const.STRD);
            List<Task> shippingTask = new List<Task> { taskVerified, taskWithoutVerified };
            while (shippingTask.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(shippingTask);
                if (finishedTask == taskVerified)
                {
                    listVerified = taskVerified.Result;
                    shippingTask.Remove(taskVerified);
                }
                else if (finishedTask == taskWithoutVerified)
                {
                    listWithoutVerified = taskWithoutVerified.Result;
                    shippingTask.Remove(taskWithoutVerified);
                }
            }
            /*Parallel.Invoke(() =>
            {
                foreach (ShippingDto sd in listWithoutVerified)
                {
                    Task`
                    t.Wait();
                }
            }
            );*/
            // Elements no autorized
            IEnumerable<ShippingDto> listShippng
                = UnionOrdersAndPreOrders(listVerified, listWithoutVerified);
            return UpdateGeolocation(listShippng);
        }

        public async Task<string> SaveDelivery(DeliveryResultDto deliveryResult)
        {
            bool exist = await this.shippingOrderRepository.FindShipping(deliveryResult);
            string path = readAppSettings.GetPathFolder();
            if (exist && (path != null || path != ""))
            {
                return this.fileRepository.WriteDeliveryStatus(deliveryResult, path);
            }
            return "NoRegister not found";
        }

        /// <summary>
        /// Search geolocation point (x, y) for orders
        /// </summary>
        /// <param name="listShippng">List of orders</param>
        /// <returns>List wich points updated</returns>
        private IEnumerable<ShippingDto> UpdateGeolocation(IEnumerable<ShippingDto> listShippng)
        {
            foreach (ShippingDto s in listShippng)
            {
                try
                {
                    string cods = s.CodigoMunicipo ?? null;
                    s.Direccion ??= "";
                    string[] st = s.Direccion.Split(Const.PIPE);
                    s.Direccion = StringTools.FixedAddress(st[Const.ZERO]);
                    s.Notas = (st.Length > Const.ONE)
                            ? StringTools.FixedAddress(st[Const.ONE])
                            : s.Notas;
                    if (s.Latitude.Equals(Const.ZERO)
                        && s.Longitude.Equals(Const.ZERO)
                        && cods != null
                        )
                    {
                        //get addres to find
                        AddressDto result = departmentRepository.GetDepAndMun(
                            cods,
                            st[Const.ZERO],
                            s.Zona ?? "SZ"
                        );
                        s.Direccion = StringTools.FixedAddress(result);
                        // update geolocation
                        AddressTools addressTools = new AddressTools(s.Direccion);
                        GeolocationDto geolocationDto =
                             addressTools.UpdateCoordinates();
                        s.Latitude = geolocationDto.Latitude;
                        s.Longitude = geolocationDto.Longitude;
                    }
                }
                catch (Exception)
                {
                    s.Latitude = Const.ZERO;
                    s.Longitude = Const.ZERO;
                }
            }
            return listShippng;
        }

        /// <summary>
        /// Remove from the list of unverified orders the orders that exist within the list of
        /// verified orders and then join the lists
        /// </summary>
        /// <param name="listVerified">List of orders verified</param>
        /// <param name="listWithoutVerified">List of orders not verified</param>
        /// <returns>Unified list of unverified and verified orders</returns>
        private IEnumerable<ShippingDto> UnionOrdersAndPreOrders(
            IEnumerable<ShippingDto> listVerified,
            IEnumerable<ShippingDto> listWithoutVerified)
        {
            if (listWithoutVerified != null)
            {
                //Selection of all unconfirmed orders
                IEnumerable<ShippingDto> rest
                = from notConfirmed in listWithoutVerified
                  where !listVerified.Any(p => p.NoRegistro == notConfirmed.NoRegistro)
                  select notConfirmed;

                //Union of confirmed items with unconfirmed item matches
                var union =
                    from confirmed in listVerified
                    join notConfirmed in listWithoutVerified
                        on confirmed.NoRegistro equals notConfirmed.NoRegistro into mat
                    from notConfirm in mat.DefaultIfEmpty()
                    select new ShippingDto
                    {
                        NoRegistro = confirmed.NoRegistro,
                        NumDocumento = (notConfirm != null) ? notConfirm.NumDocumento : Const.MISSING,
                        Confirmado = confirmed.Confirmado,
                        CodigoAgente = confirmed.CodigoAgente,
                        NombreCliente = confirmed.NombreCliente,
                        Direccion = confirmed.Direccion,
                        Telefono = confirmed.Telefono,
                        CodigoMunicipo = confirmed.CodigoMunicipo,
                        Zona = confirmed.Zona,
                        Colonia = confirmed.Colonia,
                        Latitude = confirmed.Latitude,
                        Longitude = confirmed.Longitude,
                        FechaEntrega = confirmed.FechaEntrega,
                        TotalPeso = confirmed.TotalPeso,
                        TotalVolumen = confirmed.TotalVolumen,
                        CodigoRutaDespacho = confirmed.CodigoRutaDespacho,
                        Especialidad = confirmed.Especialidad,
                        CodigoCentroDistribucion = confirmed.CodigoCentroDistribucion,
                        Fecha = confirmed.Fecha,
                        Bulto = confirmed.Bulto,
                        NombreCanalDistribucion = confirmed.NombreCanalDistribucion,
                        Notas = confirmed.Notas
                    };
                // Combine list
                return union.ToList().Concat(rest);
            }
            else
            {
                return listVerified;
            }
        }

        /// <summary>
        /// List of transports definied for Cemaco
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TransportDto>> GetTransport()
        {
            return await this.transportRepository.GetTransport();
        }
    }
}