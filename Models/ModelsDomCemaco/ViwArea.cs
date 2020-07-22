using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ViwArea
    {
        public string CodCentroDist { get; set; }
        public int CodArea { get; set; }
        public string Nombre { get; set; }
        public int? Envios { get; set; }
        public int? Paquetes { get; set; }
    }
}
