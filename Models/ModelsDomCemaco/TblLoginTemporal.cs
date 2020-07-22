using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblLoginTemporal
    {
        public string IdUsuario { get; set; }
        public string Usuario { get; set; }
        public byte[] Clave { get; set; }
    }
}
