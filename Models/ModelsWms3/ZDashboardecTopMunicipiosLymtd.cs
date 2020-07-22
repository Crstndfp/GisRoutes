using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZDashboardecTopMunicipiosLymtd
    {
        public string Periodo { get; set; }
        public string CodPais { get; set; }
        public string Pais { get; set; }
        public byte CodDepartamento { get; set; }
        public string Departamento { get; set; }
        public byte CodMunicipio { get; set; }
        public string Municipio { get; set; }
        public int? Pedidos { get; set; }
    }
}
