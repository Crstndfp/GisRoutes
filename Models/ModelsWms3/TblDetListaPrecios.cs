using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetListaPrecios
    {
        public string Sku { get; set; }
        public short CodLista { get; set; }
        public decimal? Precio { get; set; }
        public string CodMoneda { get; set; }
        public decimal? Factor { get; set; }
    }
}
