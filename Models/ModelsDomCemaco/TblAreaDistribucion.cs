using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblAreaDistribucion
    {
        public int CodArea { get; set; }
        public string CodPais { get; set; }
        public byte CodDepartamento { get; set; }
        public string Nombre { get; set; }
        public string Puntos { get; set; }
        public int Modo { get; set; }
        public string CodCentroDist { get; set; }
        public string Puntos2 { get; set; }
    }
}
