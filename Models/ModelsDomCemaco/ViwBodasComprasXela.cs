﻿using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ViwBodasComprasXela
    {
        public string NombreDelEvento { get; set; }
        public int? Cantidad { get; set; }
        public decimal? CantidadXPrecio { get; set; }
        public DateTime? FechaEvento { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
