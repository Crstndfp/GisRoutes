using Assets.Dto;
using Assets.Utilities;
using BussinesLogic.Utilities;
using Repository.DomCemaco;
using Repository.Wms3;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BussinesLogic.ShippingOrder
{
    public class UpdateCoordinates
    {
        private readonly DepartmentRepository departmentRepository;
        private readonly UpdateCoordinatesRepository updateCoordinatesService;
        private readonly UpdatePreOrderRepository updatePreOrderRepository;
        public UpdateCoordinates
            (
            DepartmentRepository departmentRepository,
            UpdateCoordinatesRepository updateCoordinatesService,
            UpdatePreOrderRepository updatePreOrderRepository
            )
        {
            this.departmentRepository = departmentRepository;
            this.updateCoordinatesService = updateCoordinatesService;
            this.updatePreOrderRepository = updatePreOrderRepository;
        }
        public async Task UpdateCoordinatesAll()
        {
            Task shippingTask = UpdateCoordinatesEnvioDir();
            Task eventTask = UpdateCoordinatesEnvento();
            Task preOrderTask = UpdateCoordinatesPreOrden();
            List<Task> updateTask = new List<Task>
            {
                shippingTask,
                eventTask,
                preOrderTask
            };
            while (updateTask.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(updateTask);
                if (finishedTask == shippingTask)
                {
                    updateTask.Remove(shippingTask);
                }
                else if (finishedTask == eventTask)
                {
                    updateTask.Remove(eventTask);
                }
                else if (finishedTask == preOrderTask)
                {
                    updateTask.Remove(preOrderTask);
                }
            }
        }
        private async Task UpdateCoordinatesEnvioDir()
        {
            IEnumerable<TableShippingDirDto> list 
                = await updateCoordinatesService.GetTblenvioDirToday();

            foreach (TableShippingDirDto t in list)
            {
                string[] st = t.Direccion.Split(Const.PIPE);
                AddressDto result = await this.departmentRepository.GetDepAndMun(
                    t.CodDepartamento + Const.GUION + t.CodMunicipio,
                    st[Const.ZERO], t.Zona);
                AddressTools addressTools = new AddressTools(
                    StringTools.FixedAddress(result));
                GeolocationDto geolocationDto = new GeolocationDto
                {
                    Latitude = t.GeoRefY,
                    Longitude = t.GeoRefX
                };
                geolocationDto = addressTools.UpdateCoordinates(geolocationDto);
                t.GeoRefY = geolocationDto.Latitude;
                t.GeoRefX = geolocationDto.Longitude;
                this.updateCoordinatesService.UpdateTblEnvioDir(t);
            }
        }
        private async Task UpdateCoordinatesEnvento()
        {
            IEnumerable<TableEventDto> list = 
                await updateCoordinatesService.GetTblEventosToday();

            foreach (TableEventDto t in list)
            {
                string[] st = t.Direccion.Split(Const.PIPE);
                AddressDto result = await departmentRepository.GetDepAndMun(
                    t.CodDepartamento + Const.GUION + t.CodMunicipio,
                    st[Const.ZERO], t.Zona);
                AddressTools addressTools = new AddressTools(
                    StringTools.FixedAddress(result));
                GeolocationDto geolocationDto = new GeolocationDto
                {
                    Latitude = t.GeoRefY,
                    Longitude = t.GeoRefX
                };
                geolocationDto = addressTools.UpdateCoordinates(geolocationDto);
                t.GeoRefY = geolocationDto.Latitude;
                t.GeoRefX = geolocationDto.Longitude;
                this.updateCoordinatesService.UpdateTblEvento(t);
            }
        }
        private async Task UpdateCoordinatesPreOrden()
        {
            IEnumerable<AuxGisRoutesDto> list = 
                await updatePreOrderRepository.GetListAuxiliarGisRoutes();
            foreach(AuxGisRoutesDto t in list)
            {
                string[] st = t.Direccion.Split(Const.PIPE);
                AddressDto result = await departmentRepository.GetDepAndMun(
                    t.CodDepartamento + Const.GUION + t.CodMunicipio,
                    st[Const.ZERO], t.Zona);
                AddressTools addressTools = new AddressTools(
                    StringTools.FixedAddress(result));
                GeolocationDto geolocationDto = new GeolocationDto
                {
                    Latitude = t.GeoRefY,
                    Longitude = t.GeoRefX
                };
                geolocationDto = addressTools.UpdateCoordinates(geolocationDto);
                t.GeoRefY = geolocationDto.Latitude;
                t.GeoRefX = geolocationDto.Longitude;
                updatePreOrderRepository.UpdateAuxiliarGisroutes(t);
            }
        }
    }
}
