using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Models.ModelsWms3;
using Assets.Dto;
using Microsoft.EntityFrameworkCore;

namespace Repository.Wms3
{
    public class PreOrdersRepository
    {
        private const string RETIRAR = "Retirar";
        private const string FORMATDATE = "yyyy-MM-dd";
        private const string ECOMMERCE = "E-COMMERCE";
        // variables de sistema
        private readonly WMS3Context _context;
        private readonly ILogger _logger;

        public PreOrdersRepository(
           WMS3Context context,
           ILogger<PreOrdersRepository> logger
           )
        {
            _context = context;
            _logger = logger; ;
        }
        public async Task<IEnumerable<ShippingDto>> GetPreOrderShipping(
            DateTime thisDay)
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
                        where DateTime.Compare(thisDay.Date, pedido.Fecha.Date) == 0
                                && pedido.DocSap.Contains("EC-")
                                && pedidoDir.Tipo.Equals("E")
                        select new ShippingDto
                        {
                            NoRegistro = pedido.DocSap,
                            NumDocumento = pedido.NumDocumento,
                            Confirmado = false,
                            CodigoAgente = (pedidoDir.Nombre.Substring(0, 7).Contains(RETIRAR))
                                            ? pedidoDir.Direccion
                                            : pedidoDir.Telefono
                                                        .Replace("502", "")
                                                        .Replace("-", "")
                                                        .Substring(0, 7),
                            NombreCliente = (pedidoDir.Nombre.Substring(0, 7).Contains(RETIRAR))
                                            ? pedidoDir.Direccion
                                            : pedidoDir.Nombre,
                            Direccion = pedidoDir.Direccion,
                            Telefono = pedidoDir.Telefono,
                            CodigoMunicipo = string.Concat(pedidoDir.CodEstado, "-", pedidoDir.CodEstado),
                            Zona = pedidoDir.Zona,
                            Colonia = "",
                            Latitude = 0,
                            Longitude = 0,
                            FechaEntrega = thisDay.Date.ToString(FORMATDATE),
                            TotalPeso = 0,
                            TotalVolumen = 0,
                            CodigoRutaDespacho = "missing",
                            Especialidad = "",
                            CodigoCentroDistribucion = pedido.CodCentroDist,
                            Fecha = pedido.Fecha.Date.ToString(FORMATDATE),
                            Bulto = 0,
                            NombreCanalDistribucion = ECOMMERCE,
                            Notas = ""
                        };
            return await query.ToListAsync();
        }
    }
}
