using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetLlamadaReemplazo
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string Sku { get; set; }
        public int Cantidad { get; set; }
        public int Modo { get; set; }
        public decimal Descuento { get; set; }
        public DateTime? Fecha { get; set; }
        public string IdUbicGarantia { get; set; }
        public string NumDocPedido { get; set; }
        public int? CodTipoFinal { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public string NumDocFinal { get; set; }
    }
}
