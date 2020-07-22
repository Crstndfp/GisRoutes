using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblZona
    {
        public string CodPais { get; set; }
        public byte CodDepartamento { get; set; }
        public byte CodMunicipio { get; set; }
        public string Zona { get; set; }
        public int GeoRefX { get; set; }
        public int GeoRefY { get; set; }
        public string Transporte { get; set; }
        public decimal? CostoTransporte { get; set; }
        public string CodAreaDist { get; set; }
    }
}
