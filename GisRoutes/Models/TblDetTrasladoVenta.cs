﻿using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblDetTrasladoVenta
    {
        public string IdEnvio { get; set; }
        public string Sku { get; set; }
        public string Color { get; set; }
        public int Cantidad { get; set; }
        public string IdTraslado { get; set; }
    }
}
