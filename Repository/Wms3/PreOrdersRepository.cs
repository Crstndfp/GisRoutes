using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Models.ModelsWms3;
using Assets.Dto;
using Assets.Utilities;
using Microsoft.EntityFrameworkCore;
using Models.Assets;

namespace Repository.Wms3
{
    public class PreOrdersRepository
    {
        private readonly WMS3Context _context;
        private readonly ILogger _logger;

        public PreOrdersRepository(
           WMS3Context context,
           ILogger<PreOrdersRepository> logger
           )
        {
            _context = context;
            _logger = logger; 
        }
        public async Task<IEnumerable<ShippingDto>> GetPreOrderShipping(
            DateTime thisDay)
        {
            try
            {
                var query = from pedido in _context.TblPedido
                            join pedidoDir in _context.TblDetPedidoDir
                                on new
                                {
                                    pedido.NumDocumento,
                                    pedido.CodTipo
                                }
                                equals new
                                {
                                    pedidoDir.NumDocumento,
                                    pedidoDir.CodTipo
                                }
                            join auxiliar in _context.ZtblAuxiliarGisroutes
                                on pedidoDir.NumDocumento equals auxiliar.NumDocumento
                            where DateTime.Compare(thisDay.Date, pedido.Fecha.Date) == Const.ZERO
                                    && pedido.DocSap.Contains(Const.STRECG)
                                    && pedidoDir.Tipo.Equals(Const.STRE)
                                    && pedidoDir.Transporte.Equals(Const.STRD)
                                    && !pedidoDir.Nombre.Substring(Const.ZERO,Const.SEVEN).Contains(Const.RETIRAR)
                                    && !auxiliar.Estado.Equals(StateAuxiliarGisRoutes.READ)
                            select new ShippingDto
                            {
                                NoRegistro = pedido.DocSap,
                                NumDocumento = pedido.NumDocumento,
                                Confirmado = false,
                                CodigoAgente = (pedidoDir.Nombre.Substring(Const.ZERO, Const.SEVEN).Contains(Const.RETIRAR))
                                                ? pedidoDir.Direccion
                                                : pedidoDir.Telefono
                                                            .Replace(Const.CODEOFAREA, Const.EMPTY)
                                                            .Replace(Const.GUION, Const.EMPTY)
                                                            .Substring(Const.ZERO, Const.SEVEN),
                                NombreCliente = (pedidoDir.Nombre.Substring(Const.ZERO, Const.SEVEN).Contains(Const.RETIRAR))
                                                ? pedidoDir.Direccion
                                                : pedidoDir.Nombre,
                                Direccion = pedidoDir.Direccion,
                                Telefono = pedidoDir.Telefono,
                                CodigoMunicipo = string.Concat(
                                    pedidoDir.CodEstado,
                                    Const.GUION, 
                                    pedidoDir.CodMunicipio),
                                Zona = pedidoDir.Zona,
                                Colonia = Const.EMPTY, 
                                Latitude = auxiliar.GeoRefY,
                                Longitude = auxiliar.GeoRefX,
                                FechaEntrega = thisDay.Date.ToString(Const.FORMATDATE),
                                TotalPeso = Const.ZERO,
                                TotalVolumen = Const.ZERO,
                                CodigoRutaDespacho = Const.MISSING,
                                Especialidad = Const.EMPTY,
                                CodigoCentroDistribucion = pedido.CodCentroDist,
                                Fecha = pedido.Fecha.Date.ToString(Const.FORMATDATE),
                                Bulto = Const.ZERO,
                                NombreCanalDistribucion = Const.ECOMMERCE,
                                Notas = Const.EMPTY
                            };
                return await query.ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e.StackTrace);
                return new List<ShippingDto>();
            }
        }
        public async Task UpdateAuxGisRoutes(string numDocumento)
        {
            try
            {
                ZtblAuxiliarGisroutes ztblAuxiliarGisroutes =
                await _context.ZtblAuxiliarGisroutes.FirstOrDefaultAsync(
                    z => z.NumDocumento == numDocumento);
                if (ztblAuxiliarGisroutes != null)
                {
                    ztblAuxiliarGisroutes.Estado = StateAuxiliarGisRoutes.READ;
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e.StackTrace);
            }
        }
    }
}