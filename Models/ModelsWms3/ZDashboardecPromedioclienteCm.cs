using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZDashboardecPromedioclienteCm
    {
        public string Periodo { get; set; }
        public string CodSocio { get; set; }
        public int? Transacciones { get; set; }
        public decimal? MontototalQ { get; set; }
        public decimal? MontoMaxq { get; set; }
        public decimal? MontoMinq { get; set; }
        public decimal MontoPromedioQ { get; set; }
        public double DesviacionStd { get; set; }
        public int? TransaccionesPromedio { get; set; }
    }
}
