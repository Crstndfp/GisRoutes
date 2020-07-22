using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ZDashboardecEventosConRegaloCm
    {
        public string Periodo { get; set; }
        public string TipoEvento { get; set; }
        public int? CantidadEventos { get; set; }
        public int? UnidadesPorEvento { get; set; }
    }
}
