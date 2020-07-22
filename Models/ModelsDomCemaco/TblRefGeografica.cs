using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblRefGeografica
    {
        public string CodPais { get; set; }
        public byte CodDepartamento { get; set; }
        public byte CodMunicipio { get; set; }
        public int CodReferencia { get; set; }
        public string Nombre { get; set; }
        public byte[] Icono { get; set; }
        public int GeoRefX { get; set; }
        public int GeoRefY { get; set; }
        public double? GeoRefX2 { get; set; }
        public double? GeoRefY2 { get; set; }
    }
}
