using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ZDashboardecEventosregistrados
    {
        public string Periodo { get; set; }
        public string TipoEvento { get; set; }
        public string TipoLista { get; set; }
        public int? EventosRegistrados { get; set; }
    }
}
