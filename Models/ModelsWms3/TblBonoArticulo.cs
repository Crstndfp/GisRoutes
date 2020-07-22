using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblBonoArticulo
    {
        public string Sku { get; set; }
        public int Cinner { get; set; }
        public int Cmaster { get; set; }
        public DateTime Del { get; set; }
        public DateTime Al { get; set; }
        public string CodBono { get; set; }
        public int Binner { get; set; }
        public int Bmaster { get; set; }
        public string Exclusiones { get; set; }
    }
}
