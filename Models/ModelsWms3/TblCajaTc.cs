using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblCajaTc
    {
        public string IdCaja { get; set; }
        public int CodAutorizador { get; set; }
        public string Terminal { get; set; }
        public int? CodTransaccion { get; set; }
        public string CodServicio { get; set; }
        public string Afiliacion { get; set; }
        public string Modo { get; set; }
    }
}
