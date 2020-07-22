using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblUsuarioTmp
    {
        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string ReqCambPwd { get; set; }
        public string Status { get; set; }
        public int CodPerfil { get; set; }
        public string Mail { get; set; }
        public DateTime UltimaModif { get; set; }
    }
}
