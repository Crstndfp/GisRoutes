using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblLogTrasladoSap
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public string Status { get; set; }
        public string DatoLog { get; set; }
        public string Trasladable { get; set; }
    }
}
