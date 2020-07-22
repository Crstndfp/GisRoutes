using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblCambioSoft
    {
        public string Version { get; set; }
        public int NoArch { get; set; }
        public string Tipo { get; set; }
        public string Funcion { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
    }
}
