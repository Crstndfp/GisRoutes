using Assets.Dto;
using Assets.Utilities;
using BussinesLogic.Utilities;
using Repository.DomCemaco;
using Repository.Wms3;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BussinesLogic.ShippingOrder
{
    public class UpdateCoordinates
    {
        private readonly DepartmentRepository departmentEnviosRepository;
        private readonly DepartmentRepository departmentEventRepository;
        private readonly DepartmentRepository departmentLecRepository;
        private readonly UpdateCoordinatesRepository updateCoordinatesEnvioService;
        private readonly UpdateCoordinatesRepository updateCoordinatesEventoService;
        private readonly UpdatePreOrderRepository updatePreOrderRepository;
        public UpdateCoordinates
            (
            DepartmentRepository departmentEnviosRepository,
            DepartmentRepository departmentEventRepository,
            DepartmentRepository departmentLecRepository,
            UpdateCoordinatesRepository updateCoordinatesEnvioService,
            UpdateCoordinatesRepository updateCoordinatesEventoService,
            UpdatePreOrderRepository updatePreOrderRepository
            )
        {
            this.departmentEnviosRepository = departmentEnviosRepository;
            this.departmentEventRepository = departmentEventRepository;
            this.departmentLecRepository = departmentLecRepository;
            this.updateCoordinatesEnvioService = updateCoordinatesEnvioService;
            this.updateCoordinatesEventoService = updateCoordinatesEventoService;
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
        public async Task UpdateCoordinatesEnvioDir()
        {
            IEnumerable<TableShippingDirDto> list
                = await updateCoordinatesEnvioService.GetTblenvioDirToday();

            foreach (TableShippingDirDto t in list)
            {
                if (t.Direccion != null)
                {
                    string[] st = t.Direccion.Split(Const.PIPE);
                    GeolocationDto geolocationDto =
                        await GetGeolocation(
                                t.CodDepartamento,
                                t.CodMunicipio,
                                st[0],
                                t.Zona,
                                departmentEnviosRepository
                            );
                    t.GeoRefY = geolocationDto.Latitude;
                    t.GeoRefX = geolocationDto.Longitude;
                    await updateCoordinatesEnvioService.UpdateTblEnvioDir(t);
                }
            }
        }
        public async Task UpdateCoordinatesEnvento()
        {
            IEnumerable<TableEventDto> list =
                await updateCoordinatesEventoService.GetTblEventosToday();
            foreach (TableEventDto t in list)
            {
                byte codDep = t.CodDepartamento ?? 0;
                byte codMun = t.CodMunicipio ?? 0;
                if (t.Direccion != null 
                    && codDep > 0 
                    && codMun > 0
                    )
                {
                    string[] st = t.Direccion.Split(Const.PIPE);
                    GeolocationDto geolocationDto =
                        await GetGeolocation(
                                codDep,
                                codMun,
                                st[0],
                                t.Zona,
                                departmentEventRepository
                            );
                    t.GeoRefY = geolocationDto.Latitude;
                    t.GeoRefX = geolocationDto.Longitude;
                    await updateCoordinatesEventoService.UpdateTblEvento(t);

                }
            }
        }
        public async Task UpdateCoordinatesPreOrden()
        {
            IEnumerable<AuxGisRoutesDto> list =
                await updatePreOrderRepository.GetListAuxiliarGisRoutes();
            foreach (AuxGisRoutesDto t in list)
            {
                if (t.Direccion != null)
                {
                    string[] st = t.Direccion.Split(Const.PIPE);
                    GeolocationDto geolocationDto =
                        await GetGeolocation(
                                t.CodDepartamento,
                                t.CodMunicipio,
                                st[0],
                                t.Zona,
                                departmentLecRepository
                            );
                    t.GeoRefY = geolocationDto.Latitude;
                    t.GeoRefX = geolocationDto.Longitude;
                    await updatePreOrderRepository.UpdateAuxiliarGisroutes(t);
                }
            }
        }
        private async Task<GeolocationDto> GetGeolocation(
                byte codDep,
                byte codMun,
                string dir,
                string zona,
                DepartmentRepository context
            )
        {
            try
            {
                AddressDto result = await context.GetDepAndMun
                                (
                                    codDep + Const.GUION + codMun,
                                    dir,
                                    zona
                                );
                if ( result.department != null)
                {
                    AddressTools addressTools = new AddressTools(
                         StringTools.FixedAddress(result));
                    return addressTools.UpdateCoordinates();
                }
                return new GeolocationDto
                {
                    Latitude = Const.ZERO,
                    Longitude = Const.ZERO
                };
            }
            catch (Exception)
            {
                return new GeolocationDto
                {
                    Latitude = Const.ZERO,
                    Longitude = Const.ZERO
                };
            }
        }
    }
}
