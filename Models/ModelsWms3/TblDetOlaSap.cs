using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetOlaSap
    {
        public string NumOla { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int Linea { get; set; }
        public string Sku { get; set; }
        public string DocSap { get; set; }
        public int LineaSap { get; set; }
        public string Status { get; set; }
        public int? CantidadSap { get; set; }
    }
}
