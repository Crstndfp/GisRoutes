using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblTipoEvento
    {
        public int CodTipo { get; set; }
        public string Nombre { get; set; }
        public int CodTipoEmp { get; set; }
        public string MensajePie { get; set; }
        public string ReqPrivilegio { get; set; }
        public string PriviAnfitrion { get; set; }
        public string RepContrato { get; set; }
    }
}
