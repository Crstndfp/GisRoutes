using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetPeriodo
    {
        public int Anyo { get; set; }
        public int Mes { get; set; }
        public int Idx { get; set; }
        public DateTime Del { get; set; }
        public DateTime Al { get; set; }
        public string Status { get; set; }
        public int SubRuta { get; set; }
        public double? Porcentaje { get; set; }
    }
}
