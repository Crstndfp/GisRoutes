using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetFacturaCs
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string Sku { get; set; }
        public string Skufact { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioBase { get; set; }
        public decimal Precio { get; set; }
        public string IdUbicReparacion { get; set; }
        public DateTime? Fecha { get; set; }
        public int? CodTipoFinal { get; set; }
        public string NumDocFinal { get; set; }
    }
}
