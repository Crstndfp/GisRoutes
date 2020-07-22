using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblArticuloPromo
    {
        public string CodPromo { get; set; }
        public string Sku { get; set; }
        public DateTime Del { get; set; }
        public DateTime Al { get; set; }
        public double Precio { get; set; }
    }
}
