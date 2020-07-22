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
        public async Task<IEnumerable<ShippingDto>> GetOrderShipping(DateTime thisDay)
        {
            IEnumerable<ShippingDto> listVerified =
                await this.shippingOrderRepository.GetOrderShipping(thisDay);
            IEnumerable<ShippingDto> listWithoutVerified =
                await this.preOrdersRepository.GetPreOrderShipping(thisDay);
            // Elements no autorized
            IEnumerable<ShippingDto> rest
                = from notConfirmed in listWithoutVerified
                  where !listVerified.Any(p => p.NoRegistro == notConfirmed.NoRegistro)
                  select notConfirmed;
            // Combine list
            IEnumerable<ShippingDto> listShippng = listVerified.Concat(rest);
            foreach (ShippingDto s in listShippng)
            {
                string[] st = s.Direccion.Split('|');
                AddressDto result = await departmentRepository.GetDepAndMun(
                    s.CodigoMunicipo, st[0], s.Zona);
                s.Direccion = StringTools.FixedAddress(result);
                s.Notas = (st.Length > 1) ? StringTools.FixedAddress(st[1]) : s.Notas;
                if (s.Latitude.Equals(0) && s.Longitude.Equals(0))
                {
                    string[] cods = s.CodigoMunicipo.Split("-");
                    AddressTools addressTools = new AddressTools(s.Direccion);
                    ShippingDto aux = addressTools.UpdateCoordinatesShipping(s);
                    s.Latitude = aux.Latitude;
                    s.Longitude = aux.Longitude;
                }
            }
            return listShippng;
        }
        public async Task<IEnumerable<Object>> GetRoutes()
        {
            return await this.shippingOrderRepository.GetRoutes();
        }
        public async Task<IEnumerable<Object>> GetRoutesByDate(DateTime thisDay)
        {
            return await this.shippingOrderRepository.GetRoutesByDate(thisDay);
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
