using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblZona
    {
        public string CodPais { get; set; }
        public byte CodDepartamento { get; set; }
        public byte CodMunicipio { get; set; }
        public string Zona { get; set; }
        public int GeoRefX { get; set; }
        public int GeoRefY { get; set; }
        public double? GeoRefX2 { get; set; }
        public double? GeoRefY2 { get; set; }
    }
}
