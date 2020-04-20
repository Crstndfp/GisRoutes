using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ZtmpEnviosLiquidacion
    {
        public string IdEvento { get; set; }
        public string Titulo { get; set; }
        public int? CantidadEnvios { get; set; }
        public decimal? MontoEnvios { get; set; }
    }
}
