﻿using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblEventoPrivi
    {
        public string IdEvento { get; set; }
        public string IdAsociado { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string IdAutorizador { get; set; }
        public string NumDocumento { get; set; }
    }
}
