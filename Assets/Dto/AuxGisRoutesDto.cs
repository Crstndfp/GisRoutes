using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assets.Dto
{
    public class AuxGisRoutesDto
    {
        public string NumDocumento { get; set; }
        public string Direccion { get; set; }
        public byte CodDepartamento { get; set; }
        public byte CodMunicipio { get; set; }
        public string Zona { get; set; }
        public string Estado { get; set; }
        public double GeoRefX { get; set; }
        public double GeoRefY { get; set; }
    }
}
