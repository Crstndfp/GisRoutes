using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblEventoTdaLiq
    {
        public string IdEvento { get; set; }
        public string CodTiendaO { get; set; }
        public string CodTiendaD { get; set; }
        public string Motivo { get; set; }
        public string IdUsuario { get; set; }
    }
}
