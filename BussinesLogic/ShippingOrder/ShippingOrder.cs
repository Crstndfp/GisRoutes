using System;
using System.Collections.Generic;
using Repository.DomCemaco;
using Repository.Wms3;
using Repository.Stream;
using Assets.Dto;
using Assets.Utilities;
using System.Threading.Tasks;
using System.Linq;
using BussinesLogic.Utilities;

namespace BussinesLogic.ShippingOrder
{
    public class ShippingOrder
    {
        private readonly ShippingOrderRepository shippingOrderRepository;
        private readonly PreOrdersRepository preOrdersRepository;
        private readonly DepartmentRepository departmentRepository;
        private readonly FileRepository fileRepository;
        public ShippingOrder
            (
            ShippingOrderRepository shippingOrderRepository,
            PreOrdersRepository preOrdersRepository,
            DepartmentRepository departmentRepository,
            FileRepository fileRepository
            )
        {
            this.shippingOrderRepository = shippingOrderRepository;
            this.preOrdersRepository = preOrdersRepository;
            this.departmentRepository = departmentRepository;
            this.fileRepository = fileRepository;
        }
        public async Task<IEnumerable<ShippingDto>> GetOrderShippingNew(DateTime thisDay)
        {
            IEnumerable<ShippingDto> listVerified = new List<ShippingDto>();
            IEnumerable<ShippingDto> listWithoutVerified = new List<ShippingDto>();
            IEnumerable<ShippingDto> listShippng = new List<ShippingDto>();
            Task<IEnumerable<ShippingDto>> taskVerified =
                shippingOrderRepository.GetOrderShipping(thisDay);
            Task<IEnumerable<ShippingDto>> taskWithoutVerified =
                preOrdersRepository.GetPreOrderShipping(thisDay);
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
                    Task t = preOrdersRepository.UpdateAuxGisRoutes(sd.NumDocumento);
                    t.Wait();
                }
            }
            );*/
            // Elements no autorized

            if (listWithoutVerified != null)
            {
                IEnumerable<ShippingDto> rest
                = from notConfirmed in listWithoutVerified
                  where !listVerified.Any(p => p.NoRegistro == notConfirmed.NoRegistro)
                  select notConfirmed;


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
                listShippng = union.ToList().Concat(rest);
            }
            else
            {
                listShippng = listVerified;
            }

            
            foreach (ShippingDto s in listShippng)
            {
                string[] st = s.Direccion.Split(Const.PIPE);
                AddressDto result = await departmentRepository.GetDepAndMun(
                    s.CodigoMunicipo, st[Const.ZERO], s.Zona);
                s.Direccion = StringTools.FixedAddress(result);
                s.Notas = (st.Length > Const.ONE) ? StringTools.FixedAddress(st[Const.ONE]) : s.Notas;
                if (s.Latitude.Equals(Const.ZERO) && s.Longitude.Equals(Const.ZERO))
                {
                    AddressTools addressTools = new AddressTools(s.Direccion);
                    GeolocationDto geolocationDto = new GeolocationDto
                    {
                        Latitude = s.Latitude,
                        Longitude = s.Longitude
                    };
                    geolocationDto = addressTools.UpdateCoordinates(geolocationDto);
                    s.Latitude = geolocationDto.Latitude;
                    s.Longitude = geolocationDto.Longitude;
                }
            }
            return listShippng;
        }
        public async Task<IEnumerable<ShippingDto>> GetOrderShipping(DateTime thisDay)
        {
            IEnumerable<ShippingDto> listShippng =
                await shippingOrderRepository.GetOrderShipping(thisDay);
            foreach (ShippingDto s in listShippng)
            {
                string[] st = s.Direccion.Split(Const.PIPE);
                AddressDto result = await departmentRepository.GetDepAndMun(
                    s.CodigoMunicipo, st[Const.ZERO], s.Zona);
                s.Direccion = StringTools.FixedAddress(result);
                s.Notas = (st.Length > Const.ONE) ? StringTools.FixedAddress(st[Const.ONE]) : s.Notas;
                if (s.Latitude.Equals(Const.ZERO) && s.Longitude.Equals(Const.ZERO))
                {
                    AddressTools addressTools = new AddressTools(s.Direccion);
                    GeolocationDto geolocationDto = new GeolocationDto
                    {
                        Latitude = s.Latitude,
                        Longitude = s.Longitude
                    };
                    geolocationDto = addressTools.UpdateCoordinates(geolocationDto);
                    s.Latitude = geolocationDto.Latitude;
                    s.Longitude = geolocationDto.Longitude;
                }
            }
            return listShippng;
        }
        public async Task<string> SaveDelivery(DeliveryResultDto deliveryResult)
        {
            bool exist = await this.shippingOrderRepository.FindShipping(deliveryResult);
            if (exist)
            {
                return this.fileRepository.WriteDeliveryStatus(deliveryResult);
            }
            return "NoRegister not found";
        }
    }
}
