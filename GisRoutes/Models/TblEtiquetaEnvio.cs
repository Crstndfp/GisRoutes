using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblEtiquetaEnvio
    {
        public string CodTienda { get; set; }
        public string Etiqueta { get; set; }
        public DateTime FechaGen { get; set; }
        public string IdEnvio { get; set; }
    }
}
