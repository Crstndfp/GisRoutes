using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblIdtarjetaComision
    {
        public string IdtarjetaDesde { get; set; }
        public string IdtarjetaHasta { get; set; }
        public decimal MontoMin { get; set; }
        public decimal MontoMax { get; set; }
        public double Comision { get; set; }
    }
}
