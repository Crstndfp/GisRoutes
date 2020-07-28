using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Models.ModelsDomCemaco;
using Assets.Dto;
using Assets.Utilities;

namespace Repository.DomCemaco
{
    public class ShippingOrderRepository
    {
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
            try
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
                            where DateTime.Compare(thisDay.Date, ruta.Fecha.Date) == Const.ZERO
                                && (!detRuta.Status.Equals(Const.STRE) 
                                    || !detRuta.Status.Equals(Const.STRZ))
                                && ruta.NumVehiculo.Equals(Const.VEHICLEGISROUTES)
                            select new ShippingDto
                            {
                                NoRegistro = envio.IdEnvio,
                                NumDocumento = Const.MISSING,
                                Confirmado = true,
                                CodigoAgente = (envio.Comprador.Substring(Const.ZERO, Const.SEVEN)
                                                                .Contains(Const.RETIRAR))
                                                ? subEnvioDir.Direccion
                                                : (envio.TelEntrega.Length == Const.ZERO
                                                && envio.IdEvento == null)
                                                    ? envio.IdEnvio
                                                    : (envio.Tipo == Const.INTWEDDING)
                                                        ? subEnvento.IdEvento
                                                        : envio.TelEntrega
                                                            .Replace(Const.CODEOFAREA, Const.EMPTY)
                                                            .Replace(Const.GUION, Const.EMPTY)
                                                            .Substring(Const.ZERO, Const.SEVEN),
                                NombreCliente = (envio.Comprador.Substring(Const.ZERO, Const.SEVEN)
                                                                .Contains(Const.RETIRAR))
                                                ? subEnvioDir.Direccion
                                                : (envio.Tipo == Const.INTWEDDING)
                                                    ? subEnvento.Titulo
                                                    : envio.Comprador,
                                Direccion = (envio.Tipo == Const.INTWEDDING)
                                            ? subEnvento.Direccion : subEnvioDir.Direccion,
                                Telefono = (envio.Tipo == Const.INTWEDDING)
                                            ? subEnvento.Telefono
                                            : envio.TelEntrega,
                                CodigoMunicipo = (envio.Tipo == Const.INTWEDDING)
                                                 ? string.Concat(
                                                     subEnvento.CodDepartamento, 
                                                     Const.GUION, 
                                                     subEnvento.CodMunicipio
                                                     )
                                                 : string.Concat(
                                                     subEnvioDir.CodDepartamento, 
                                                     Const.GUION, 
                                                     subEnvioDir.CodMunicipio),
                                Zona = (envio.Tipo == Const.INTWEDDING)
                                        ? subEnvento.Zona : subEnvioDir.Zona,
                                Colonia = Const.EMPTY,
                                Latitude = (envio.Tipo == Const.INTWEDDING)
                                            ? subEnvento.GeoRefY : subEnvioDir.GeoRefY,
                                Longitude = (envio.Tipo == Const.INTWEDDING)
                                            ? subEnvento.GeoRefX : subEnvioDir.GeoRefX,
                                FechaEntrega = thisDay.Date.ToString(Const.FORMATDATE),
                                TotalPeso = Const.ZERO,
                                TotalVolumen = Const.ZERO,
                                CodigoRutaDespacho = detRuta.IdRuta,
                                Especialidad = Const.EMPTY,
                                CodigoCentroDistribucion = ruta.CodCentroDist,
                                Fecha = envio.Fecha.Date.ToString(Const.FORMATDATE),
                                Bulto = envio.Paquetes,
                                NombreCanalDistribucion = (envio.Tipo == Const.INTWEDDING)
                                        ? Const.WEDDING
                                        : (envio.IdEnvio.Contains(Const.STREC))
                                            ? Const.ECOMMERCE
                                            : Const.HOME,

                                Notas = subEnvento.Referencias
                            };
                return await query.ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e.StackTrace);
                return new List<ShippingDto>();
            }
            
        }
        public async Task<bool> FindShipping(DeliveryResultDto deliveryResult)
        {
            try
            {
                return await _context.TblEnvio.Where(
                    e => e.IdEnvio == deliveryResult.NoRegistro).AnyAsync();

            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e.StackTrace);
                return false;
            }
        }
    }
}
