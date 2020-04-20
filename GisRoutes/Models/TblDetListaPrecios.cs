using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblDetListaPrecios
    {
        public string Sku { get; set; }
        public short CodLista { get; set; }
        public decimal? Precio { get; set; }
    }
}
