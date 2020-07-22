using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblRegaloRemplazo
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int Linea { get; set; }
        public string NumLlamadaServ { get; set; }
        public DateTime? AnulacionEnvio { get; set; }
    }
}
