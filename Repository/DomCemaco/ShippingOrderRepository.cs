using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Models.ModelsDomCemaco;
using Assets.Dto;

namespace Repository.DomCemaco
{
    public class ShippingOrderRepository
    {
        private const string VEHICLEGISROUTES = "GISROUTES";
        private const string FORMATDATE = "yyyy-MM-dd";
        private const string WEDDING = "BODAS";
        private const string ECOMMERCE = "E-COMMERCE";
        private const string HOME = "DOMICILIO";
        private const string RETIRAR = "Retirar";
        private const string ACTIVE = "Activa";
        private const string RUTA = "RUTA-";

        private readonly DomCemacoContext _context;
        private readonly ILogger _logger;

        public ShippingOrderRepository
            (
                DomCemacoContext context,
                ILogger<ShippingOrderRepository> logger
            )
        {
            _context = context;
            _logger = logger;
        }
        public async Task<IEnumerable<ShippingDto>> GetOrderShipping(DateTime thisDay)
        {
            var query = from ruta in _context.TblRuta
                        join detRuta in _context.TblDetRuta
                            on ruta.IdRuta equals detRuta.IdRuta
                        join envio in _context.TblEnvio
                            on detRuta.IdEnvio equals envio.IdEnvio
                        join envioDir in _context.TblEnvioDir
                            on envio.IdEnvio equals envioDir.IdEnvio into eD
                        from subEnvioDir in eD.DefaultIfEmpty()
                        join evento in _context.TblEvento
                            on envio.IdEvento equals evento.IdEvento into ev
                        from subEnvento in ev.DefaultIfEmpty()
                        where DateTime.Compare(thisDay.Date, ruta.Fecha.Date) == 0
                            && (!detRuta.Status.Equals("E") || !detRuta.Status.Equals("Z"))
                            && ruta.NumVehiculo.Equals(VEHICLEGISROUTES)
                        select new ShippingDto
                        {
                            NoRegistro = envio.IdEnvio,
                            NumDocumento = "missing",
                            Confirmado = true,
                            CodigoAgente = (envio.Comprador.Substring(0, 7).Contains(RETIRAR))
                                            ? subEnvioDir.Direccion
                                            : (envio.TelEntrega.Length == 0
                                            && envio.IdEvento == null)
                                                ? envio.IdEnvio
                                                : (envio.Tipo == 1)
                                                    ? subEnvento.IdEvento
                                                    : envio.TelEntrega
                                                        .Replace("502", "")
                                                        .Replace("-", "")
                                                        .Substring(0, 7),
                            NombreCliente = (envio.Comprador.Substring(0, 7).Contains(RETIRAR))
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
                            FechaEntrega = thisDay.Date.ToString(FORMATDATE),
                            TotalPeso = 0,
                            TotalVolumen = 0,
                            CodigoRutaDespacho = detRuta.IdRuta,
                            Especialidad = "",
                            CodigoCentroDistribucion = ruta.CodCentroDist,
                            Fecha = envio.Fecha.Date.ToString(FORMATDATE),
                            Bulto = envio.Paquetes,
                            NombreCanalDistribucion = (envio.Tipo == 1)
                                    ? WEDDING
                                    : (envio.IdEnvio.Contains("EC"))
                                        ? ECOMMERCE
                                        : HOME,

                            Notas = subEnvento.Referencias
                        };
            return await query.ToListAsync();
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
                            NombreRuta = string.Concat(RUTA, ruta.IdRuta),
                            CodigoTipoRuta = ruta.NumVehiculo,
                            TipoTransporte = tipoVehiculo.Nombre,
                            CodigoSucursal = ruta.CodCentroDist,
                            Activa = ACTIVE
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
                            NombreRuta = string.Concat(RUTA, ruta.IdRuta),
                            CodigoTipoRuta = ruta.NumVehiculo,
                            TipoTransporte = tipoVehiculo.Nombre,
                            CodigoSucursal = ruta.CodCentroDist,
                            Activa = ACTIVE
                        };
            return await query.Distinct().ToListAsync();
        }
        public async Task<bool> FindShipping(DeliveryResultDto deliveryResult)
        {
            return await _context.TblEnvio.Where(
                e => e.IdEnvio == deliveryResult.NoRegistro).AnyAsync();
        }
    }
}
