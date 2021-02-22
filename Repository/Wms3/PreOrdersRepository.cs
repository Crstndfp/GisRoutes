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
        /// <summary>
        /// This method searches for orders by type of transport in the database.
        /// </summary>
        /// <param name="day">Day of find</param>
        /// <param name="transport">Transport to find between gisroutes or chicago</param>
        /// <returns>A list with all orders filtered by day and transport</returns>
        public async Task<IEnumerable<ShippingDto>> GetPreOrderShipping(
            DateTime day, string transport)
        {
            try
            {
                var query = from pedido in _context.TblPedido                                                       // table of the orders
                            join pedidoDir in _context.TblDetPedidoDir                                              // table of addresses for the orders
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
                            join auxiliar in _context.ZtblAuxiliarGisroutes                                         // table of the geolocdation points
                                on pedidoDir.NumDocumento equals auxiliar.NumDocumento
                            where (DateTime.Compare(day.AddDays(-30).Date, pedido.Fecha.Date) < Const.ZERO                       // date of find
                                    || DateTime.Compare(day.Date, pedido.Fecha.Date) == Const.ZERO)
                                    && (
                                        pedido.Status.Equals("A") ||
                                        pedido.Status.Equals("D") ||
                                        pedido.Status.Equals("C") ||
                                        pedido.Status.Equals("O") ||
                                        pedido.Status.Equals("K") ||
                                        pedido.Status.Equals("F") ||
                                        pedido.Status.Equals("0") ||
                                        pedido.Status.Equals("Q") ||
                                        pedido.Status.Equals("R") ||
                                        pedido.Status.Equals("P")
                                    )
                                    && pedidoDir.Tipo.Equals(Const.STRE)                                            // filter ordert with address
                                    && pedidoDir.Transporte.Equals(transport)                                       // filter by transport gisroutes or chicago
                                    && !pedidoDir.Nombre.Substring(Const.ZERO,Const.SEVEN).Contains(Const.RETIRAR)  // Quuit orders stored pickup 
                                    && !auxiliar.Estado.Equals(StateAuxiliarGisRoutes.READ)                         // Orders no read
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
                                FechaEntrega = day.Date.ToString(Const.FORMATDATE),
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