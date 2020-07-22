using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZDashboardecFillrateBodaIntercambio
    {
        public string Periodo { get; set; }
        public int? Pedidos { get; set; }
        public int? UnidadesPed { get; set; }
        public decimal? FillRate { get; set; }
        public int? PedIncomp { get; set; }
        public int? PedSindespacho { get; set; }
        public string Tipo { get; set; }
    }
}
