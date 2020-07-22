using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class Calendarioretail
    {
        public int AnioCalendario { get; set; }
        public int MesCalendario { get; set; }
        public int DiaCalendario { get; set; }
        public DateTime? FechaCalendario { get; set; }
        public int? MesRetail { get; set; }
        public int? SemanaRetail { get; set; }
        public int? AnioRetail { get; set; }
    }
}
