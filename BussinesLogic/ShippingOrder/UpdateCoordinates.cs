using Assets.Dto;
using Assets.Utilities;
using BussinesLogic.Utilities;
using Repository.DomCemaco;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BussinesLogic.ShippingOrder
{
    public class UpdateCoordinates
    {
        private readonly DepartmentRepository departmentRepository;
        private readonly UpdateCoordinatesRepository updateCoordinatesService;
        public UpdateCoordinates
            (
            DepartmentRepository departmentRepository,
            UpdateCoordinatesRepository updateCoordinatesService
            )
        {
            this.departmentRepository = departmentRepository;
            this.updateCoordinatesService = updateCoordinatesService;
        }
        public async Task<IEnumerable<TableShippingDirDto>> UpdateCoordinatesEnvioDir()
        {
            IEnumerable<TableShippingDirDto> list 
                = await this.updateCoordinatesService.GetTblenvioDirToday();

            foreach (TableShippingDirDto t in list)
            {
                string[] st = t.Direccion.Split('|');
                AddressDto result = await this.departmentRepository.GetDepAndMun(
                    t.CodDepartamento + "-" + t.CodMunicipio,
                    st[0], t.Zona);
                AddressTools addressTools = new AddressTools(
                    StringTools.FixedAddress(result));
                TableShippingDirDto aux = addressTools.UpdateCoordinatesEnvioDir(t);
                t.GeoRefY = aux.GeoRefY;
                t.GeoRefX = aux.GeoRefX;
                this.updateCoordinatesService.UpdateTblEnvioDir(t);
            }
            return list;
        }
        public async Task<IEnumerable<TableEventDto>> UpdateCoordinatesEnvento()
        {
            IEnumerable<TableEventDto> list = await this.updateCoordinatesService.GetTblEventosToday();

            foreach (TableEventDto t in list)
            {
                string[] st = t.Direccion.Split('|');
                AddressDto result = await departmentRepository.GetDepAndMun(
                    t.CodDepartamento + "-" + t.CodMunicipio,
                    st[0], t.Zona);
                AddressTools addressTools = new AddressTools(
                    StringTools.FixedAddress(result));
                TableEventDto aux = addressTools.UpdateCoordinatesEvento(t);
                t.GeoRefY = aux.GeoRefY;
                t.GeoRefX = aux.GeoRefX;
                this.updateCoordinatesService.UpdateTblEvento(t);
            }
            return list;
        }
    }
}
