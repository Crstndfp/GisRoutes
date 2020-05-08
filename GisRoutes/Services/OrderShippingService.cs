using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GisRoutes.Models;
using Microsoft.AspNetCore.Mvc;
using GisRoutes.RestFull;
using GisRoutes.Dto;
using Newtonsoft.Json.Linq;
using GisRoutes.Utilities;

namespace GisRoutes.Services
{
    public class OrderShippingService
    {
        private readonly DomCemacoContext _context;
        private readonly DepartmentService departmentService;

        public OrderShippingService(
            DomCemacoContext context,
            DepartmentService departmentService
            )
        {
            _context = context;
            this.departmentService = departmentService;
        }

        public async Task<IEnumerable<Shipping>> GetOrderShipping(DateTime thisDay)
        {

            var query = from envio in _context.TblEnvio
                        join detRuta in _context.TblDetRuta
                            on envio.IdEnvio equals detRuta.IdEnvio
                        join envioDir in _context.TblEnvioDir
                            on envio.IdEnvio equals envioDir.IdEnvio into eD
                            from subEnvioDir in eD.DefaultIfEmpty()
                        join evento in _context.TblEvento
                            on envio.IdEvento equals evento.IdEvento into ev
                            from subEnvento in ev.DefaultIfEmpty()
                        where DateTime.Compare(thisDay.AddDays(-1).Date, envio.Fecha.Date) == 0
                        select new Shipping
                        {
                            NoRegistro = envio.IdEnvio,
                            CodigoAgente = (envio.Comprador.Substring(0, 7).Contains("Retirar"))
                                            ? subEnvioDir.Direccion
                                            : (envio.TelEntrega.Length == 0)
                                                ? envio.IdEnvio
                                                : (envio.Tipo == 1)
                                                    ? subEnvento.IdEvento
                                                    : envio.TelEntrega.Replace("502", "").Replace("-", "").Substring(1, 8),
                            NombreCliente = (envio.Comprador.Substring(0, 7).Contains("Retirar"))
                                            ? subEnvioDir.Direccion
                                            : (envio.Tipo == 1)
                                                ? subEnvento.Titulo
                                                : envio.Comprador,
                            Direccion = (envio.Tipo == 1)
                                        ? subEnvento.Direccion : subEnvioDir.Direccion,
                            Telefono = (envio.Tipo == 1)
                                        ? subEnvento.Telefono
                                        : envio.TelEntrega,
                            CodigoMunicipo = (envio.Tipo == 1)
                                             ? string.Concat(subEnvento.CodDepartamento, "-", subEnvento.CodMunicipio)
                                             : string.Concat(subEnvioDir.CodDepartamento, "-", subEnvioDir.CodMunicipio),
                            Zona = (envio.Tipo == 1)
                                    ? subEnvento.Zona : subEnvioDir.Zona,
                            Colonia = "",
                            Latitude = (envio.Tipo == 1)
                                        ? subEnvento.GeoRefY : subEnvioDir.GeoRefY,
                            Longitude = (envio.Tipo == 1)
                                        ? subEnvento.GeoRefX : subEnvioDir.GeoRefX,
                            FechaEntrega = thisDay.Date.ToString("yyyy-MM-dd"),
                            TotalPeso = 0,
                            TotalVolumen = 0,
                            CodigoRutaDespacho = detRuta.IdRuta,
                            Especialidad = "",
                            CodigoDistribuidora = "",
                            Fecha = envio.Fecha.Date.ToString("yyyy-MM-dd"),
                            Bulto = envio.Paquetes,
                            Notas = subEnvento.Referencias
                        };

            IEnumerable<Shipping> listShippng = await query.ToListAsync();
            foreach (Shipping s in listShippng)
            {
                if ( s.Latitude.Equals(0) && s.Longitude.Equals(0))
                {
                    string[] cods = s.CodigoMunicipo.Split("-");
                    AddressTools addressTools = new AddressTools(
                        s.Direccion, 
                        s.Zona, 
                        await this.departmentService.GetDepAndMun(
                            byte.Parse(cods[0]), byte.Parse(cods[1])));
                    Shipping aux = addressTools.UpdateCoordinatesShipping(s);
                    s.Latitude = aux.Latitude;
                    s.Longitude = aux.Longitude;
                }
            }

            return listShippng;
        }

        public async Task<IEnumerable<Object>> GetRoutes()
        {
            var query = from ruta in _context.TblRuta
                        join vehiculo in _context.TblVehiculo
                            on ruta.NumVehiculo equals vehiculo.NumVehiculo
                        join tipoVehiculo in _context.TblTipoVehiculo
                            on vehiculo.CodTipo equals tipoVehiculo.CodTipo
                        select new
                        {
                            CodigoRuta = ruta.IdRuta,
                            NombreRuta = string.Concat("RUTA-", ruta.IdRuta),
                            CodigoTipoRuta = ruta.NumVehiculo,
                            TipoTransporte = tipoVehiculo.Nombre,
                            CodigoSucursal = ruta.CodCentroDist,
                            Activa = "Activa"
                        };
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<Object>> GetRoutesByDate(DateTime thisDay)
        {
            var query = from envio in _context.TblEnvio
                        join dRuta in _context.TblDetRuta
                            on envio.IdEnvio equals dRuta.IdEnvio
                        join ruta in _context.TblRuta
                            on dRuta.IdRuta equals ruta.IdRuta
                        join vehiculo in _context.TblVehiculo
                            on ruta.NumVehiculo equals vehiculo.NumVehiculo
                        join tipoVehiculo in _context.TblTipoVehiculo
                            on vehiculo.CodTipo equals tipoVehiculo.CodTipo
                        where DateTime.Compare(thisDay.AddDays(-1).Date, envio.Fecha.Date) == 0
                        select new
                        {
                            CodigoRuta = ruta.IdRuta,
                            NombreRuta = string.Concat("RUTA-", ruta.IdRuta),
                            CodigoTipoRuta = ruta.NumVehiculo,
                            TipoTransporte = tipoVehiculo.Nombre,
                            CodigoSucursal = ruta.CodCentroDist,
                            Activa = "Activa"
                        };
            return await query.Distinct().ToListAsync();
        }

        public string SaveDelivery(DeliveryResult deliveryResult)
        {
            if (_context.TblEnvio.Where(
                e => e.IdEnvio == deliveryResult.NoRegistro).Any())
            {
                FileService fileService = new FileService();
                return fileService.WriteDeliveryStatus(deliveryResult);
            }
            return "NoRegister not found";
        }
    }
}
