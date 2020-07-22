using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetFactura
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int LineaOrig { get; set; }
        public string Sku { get; set; }
        public string Skufact { get; set; }
        public int CantidadBase { get; set; }
        public int Cantidad { get; set; }
        public string IdUbicAuditoria { get; set; }
        public int Bulto { get; set; }
        public DateTime? Fecha { get; set; }
        public string IdAuditor { get; set; }
        public int? CodTipoFinal { get; set; }
        public string NumDocFinal { get; set; }
        public string Tarima { get; set; }
        public int? CantidadEmp { get; set; }
    }
}
