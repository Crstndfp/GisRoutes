using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ViwAreaBodas
    {
        public string CodCentroDist { get; set; }
        public int CodArea { get; set; }
        public string Nombre { get; set; }
        public int? Envios { get; set; }
        public int? Paquetes { get; set; }
    }
}
