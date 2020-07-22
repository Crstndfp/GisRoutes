using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblTiempoTemporal
    {
        public string Fecha { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Day { get; set; }
        public int? Week { get; set; }
        public int? Quarter { get; set; }
        public int Semestre { get; set; }
        public string Ytd { get; set; }
        public string Mtd { get; set; }
        public string StartLw { get; set; }
        public string StartLytd { get; set; }
        public string EndLytd { get; set; }
        public string StartLmtd { get; set; }
        public string EndLmtd { get; set; }
    }
}
