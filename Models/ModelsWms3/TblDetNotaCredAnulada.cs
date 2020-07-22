using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetNotaCredAnulada
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string Sku { get; set; }
        public int Cantidad { get; set; }
        public int? CodTipoFinal { get; set; }
        public string NumDocFinal { get; set; }
    }
}
