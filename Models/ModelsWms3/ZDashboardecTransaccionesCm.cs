using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZDashboardecTransaccionesCm
    {
        public string Periodo { get; set; }
        public int? Transacciones { get; set; }
        public decimal? MontoQ { get; set; }
        public decimal? TransaccionPromedioQ { get; set; }
        public decimal? UnidadesPromedio { get; set; }
    }
}
