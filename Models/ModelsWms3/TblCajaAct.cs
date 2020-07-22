using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblCajaAct
    {
        public string IdCaja { get; set; }
        public string IdTarea { get; set; }
        public int CodTipo { get; set; }
        public DateTime? FechaInicio { get; set; }
        public string Status { get; set; }
    }
}
