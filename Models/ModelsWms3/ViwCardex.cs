using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ViwCardex
    {
        public DateTime? Fecha { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string DocSap { get; set; }
        public string Sku { get; set; }
        public int CodTipoOrg { get; set; }
        public string NumDocOrg { get; set; }
        public string OrdenCompra { get; set; }
        public string Pedido { get; set; }
        public string Reclamo { get; set; }
        public int Ingresos { get; set; }
        public int Traslados { get; set; }
        public int Salidas { get; set; }
        public int? Facturado { get; set; }
        public int? AnulFactura { get; set; }
        public string IdUsuario { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public int? Neto { get; set; }
    }
}
