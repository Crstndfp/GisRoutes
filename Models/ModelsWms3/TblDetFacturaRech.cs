using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetFacturaRech
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string Sku { get; set; }
        public string Skufact { get; set; }
        public int Cantidad { get; set; }
        public DateTime? Fecha { get; set; }
        public string IdAuditor { get; set; }
    }
}
