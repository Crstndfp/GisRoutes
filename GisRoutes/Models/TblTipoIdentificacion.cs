using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblTipoIdentificacion
    {
        public int CodTipo { get; set; }
        public string Nombre { get; set; }
        public string Series { get; set; }
        public string Obligatorio { get; set; }
    }
}
