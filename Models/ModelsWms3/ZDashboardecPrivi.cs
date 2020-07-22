using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZDashboardecPrivi
    {
        public string Periodo { get; set; }
        public string Privilegio { get; set; }
        public decimal? Monto { get; set; }
        public int? Pedidos { get; set; }
    }
}
