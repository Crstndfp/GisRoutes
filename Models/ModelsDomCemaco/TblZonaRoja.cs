using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblZonaRoja
    {
        public string CodPais { get; set; }
        public byte CodDepartamento { get; set; }
        public byte CodMunicipio { get; set; }
        public int CodZona { get; set; }
        public string Nombre { get; set; }
        public string Puntos { get; set; }
        public string Puntos2 { get; set; }
        public int? CodTipo { get; set; }
    }
}
