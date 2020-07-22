using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZDashboardecFillrate
    {
        public string Periodo { get; set; }
        public int? Pedidos { get; set; }
        public int? UnidadesPed { get; set; }
        public int? UnidadesDesp { get; set; }
        public decimal? FillRate { get; set; }
        public int? PedImcomp { get; set; }
        public int? PedSindespacho { get; set; }
    }
}
