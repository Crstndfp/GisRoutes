using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblEnvioEmp
    {
        public string IdEnvio { get; set; }
        public string IdPersonal { get; set; }
        public string IdRegistro { get; set; }
        public DateTime FechaEmp { get; set; }
        public string Ubicacion { get; set; }
    }
}
