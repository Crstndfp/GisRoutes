using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblEnvioOs
    {
        public string IdEnvio { get; set; }
        public string Direccion { get; set; }
        public string Fax { get; set; }
        public DateTime VencimientoGar { get; set; }
    }
}
