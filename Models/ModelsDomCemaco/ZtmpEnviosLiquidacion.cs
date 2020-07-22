using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ZtmpEnviosLiquidacion
    {
        public string IdEvento { get; set; }
        public string Titulo { get; set; }
        public int? CantidadEnvios { get; set; }
        public decimal? MontoEnvios { get; set; }
    }
}
