using Assets.Dto;
using Assets.Utilities;
using BussinesLogic.Utilities;
using Microsoft.Extensions.Logging;
using Repository.DomCemaco;
using Repository.Wms3;
using System;
using System.Collections.Generic;

namespace BussinesLogic.ShippingOrder
{
    public class UpdateCoordinates
    {
        private readonly DepartmentRepositoryLec departmentRepositoryLec;
        private readonly UpdateCoordinatesRepository updateCoordinatesEnvioService;
        private readonly UpdatePreOrderRepository updatePreOrderRepository;
        private readonly ILogger _logger;

        public UpdateCoordinates
            (
            DepartmentRepositoryLec departmentRepositoryLec,
            UpdateCoordinatesRepository updateCoordinatesEnvioService,
            UpdatePreOrderRepository updatePreOrderRepository,
            ILogger<UpdateCoordinates> logger
            )
        {
            this.departmentRepositoryLec = departmentRepositoryLec;
            this.updateCoordinatesEnvioService = updateCoordinatesEnvioService;
            this.updatePreOrderRepository = updatePreOrderRepository;
            _logger = logger;
        }

        public void UpdateCoordinatesEnvioDir()
        {
            IEnumerable<TableShippingDirDto> list
                = updateCoordinatesEnvioService.GetTblenvioDirToday();

            foreach (TableShippingDirDto t in list)
            {
                if (t.Direccion != null)
                {
                    try
                    {
                        string[] st = t.Direccion.Split(Const.PIPE);
                        GeolocationDto geolocationDto =
                            GetGeolocation(
                                    t.CodDepartamento,
                                    t.CodMunicipio,
                                    st[0],
                                    t.Zona
                                );
                        t.GeoRefY = geolocationDto.Latitude;
                        t.GeoRefX = geolocationDto.Longitude;
                        updateCoordinatesEnvioService.UpdateTblEnvioDir(t);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                    }
                }
            }
        }

        public void UpdateCoordinatesEnvento()
        {
            IEnumerable<TableEventDto> list =
                updateCoordinatesEnvioService.GetTblEventosToday();
            foreach (TableEventDto t in list)
            {
                byte codDep = t.CodDepartamento ?? 0;
                byte codMun = t.CodMunicipio ?? 0;
                if (t.Direccion != null
                    && codDep > 0
                    && codMun > 0
                    )
                {
                    try
                    {
                        string[] st = t.Direccion.Split(Const.PIPE);
                        GeolocationDto geolocationDto =
                            GetGeolocation(
                                    codDep,
                                    codMun,
                                    st[0],
                                    t.Zona
                                );
                        t.GeoRefY = geolocationDto.Latitude;
                        t.GeoRefX = geolocationDto.Longitude;
                        updateCoordinatesEnvioService.UpdateTblEvento(t);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                    }
                }
            }
        }

        public void UpdateCoordinatesPreOrden()
        {
            IEnumerable<AuxGisRoutesDto> list =
                updatePreOrderRepository.GetListAuxiliarGisRoutes();
            foreach (AuxGisRoutesDto t in list)
            {
                if (t.Direccion != null)
                {
                    try
                    {
                        string[] st = t.Direccion.Split(Const.PIPE);
                        GeolocationDto geolocationDto =
                            GetGeolocation(
                                    t.CodDepartamento,
                                    t.CodMunicipio,
                                    st[0],
                                    t.Zona
                                );
                        t.GeoRefY = geolocationDto.Latitude;
                        t.GeoRefX = geolocationDto.Longitude;
                        updatePreOrderRepository.UpdateAuxiliarGisroutes(t);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                    }
                }
            }
        }

        private GeolocationDto GetGeolocation(
                byte codDep,
                byte codMun,
                string dir,
                string zona
            )
        {
            try
            {
                AddressDto result = departmentRepositoryLec.GetDepAndMun
                                (
                                    codDep + Const.GUION + codMun,
                                    dir,
                                    zona
                                );
                AddressTools addressTools = new AddressTools(
                         StringTools.FixedAddress(result));
                return addressTools.UpdateCoordinates();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}