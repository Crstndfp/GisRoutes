using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ViwDirEnvio
    {
        public string IdEnvio { get; set; }
        public int GeoRefX { get; set; }
        public int GeoRefY { get; set; }
        public string CodPais { get; set; }
        public int? CodDepartamento { get; set; }
        public int? CodMunicipio { get; set; }
        public string Zona { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string IdEvento { get; set; }
    }
}
