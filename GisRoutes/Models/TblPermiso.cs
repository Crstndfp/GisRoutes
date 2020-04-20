using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblPermiso
    {
        public int CodPerfil { get; set; }
        public string CodAplicacion { get; set; }
        public string Ejecutar { get; set; }
        public string Altas { get; set; }
        public string Bajas { get; set; }
        public string Cambios { get; set; }
    }
}
