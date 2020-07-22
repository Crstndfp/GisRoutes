using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblDetListaPrecios
    {
        public string Sku { get; set; }
        public short CodLista { get; set; }
        public decimal? Precio { get; set; }
    }
}
