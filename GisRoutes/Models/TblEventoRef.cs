﻿using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblEventoRef
    {
        public string IdEvento { get; set; }
        public string IdEventoRef { get; set; }
        public int? Puntos { get; set; }
        public string NumDocPuntos { get; set; }
        public DateTime? FechaAcum { get; set; }
    }
}
