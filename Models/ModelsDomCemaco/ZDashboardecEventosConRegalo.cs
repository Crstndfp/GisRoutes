﻿using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ZDashboardecEventosConRegalo
    {
        public string Periodo { get; set; }
        public string TipoEvento { get; set; }
        public int? CantidadEventos { get; set; }
        public decimal? UnidadesPorEvento { get; set; }
    }
}
