using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ViwDirEvento
    {
        public string IdEvento { get; set; }
        public string CodPais { get; set; }
        public int? CodDepartamento { get; set; }
        public int? CodMunicipio { get; set; }
        public string Zona { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
