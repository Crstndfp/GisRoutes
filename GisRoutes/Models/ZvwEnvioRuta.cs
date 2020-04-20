using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ZvwEnvioRuta
    {
        public string IdEnvio { get; set; }
        public DateTime? FechaRutaEntrega { get; set; }
        public string NumeroRutaEntrega { get; set; }
    }
}
