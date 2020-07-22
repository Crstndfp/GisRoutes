using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblCanjeCupon
    {
        public string IdEvento { get; set; }
        public int TipoCupon { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public string IdPersonal { get; set; }
        public string Nombre { get; set; }
    }
}
