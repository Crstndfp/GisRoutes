﻿using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblObsEventoExpo
    {
        public string IdEvento { get; set; }
        public int Ind { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public string Observaciones { get; set; }
        public string Imprimible { get; set; }
    }
}
