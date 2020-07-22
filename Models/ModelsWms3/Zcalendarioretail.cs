using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class Zcalendarioretail
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
