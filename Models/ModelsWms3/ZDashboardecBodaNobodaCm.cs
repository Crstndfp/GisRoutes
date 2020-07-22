using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZDashboardecBodaNobodaCm
    {
        public string Periodo { get; set; }
        public string TipoPedido { get; set; }
        public int? Transacciones { get; set; }
        public decimal? MontoQ { get; set; }
        public decimal? TransaccionPromedioQ { get; set; }
        public string Intercambio { get; set; }
        public decimal? UnidadesPromedio { get; set; }
    }
}
