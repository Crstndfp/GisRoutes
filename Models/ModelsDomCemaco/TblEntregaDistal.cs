﻿using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblEntregaDistal
    {
        public string IdEnvio { get; set; }
        public string Nombre { get; set; }
        public int Resultado { get; set; }
        public DateTime Fecha { get; set; }
        public string IdRuta { get; set; }
    }
}
