using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZDashboardecFillrateCentroCm
    {
        public string Periodo { get; set; }
        public string Centro { get; set; }
        public int? Solicitado { get; set; }
        public int? Despachado { get; set; }
        public decimal? FillRate { get; set; }
    }
}
