﻿using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblEnvioNc
    {
        public string IdEnvio { get; set; }
        public DateTime Fecha { get; set; }
        public string Nota { get; set; }
        public string Nombre { get; set; }
        public string Nit { get; set; }
        public string CodUbicacion { get; set; }
        public string IdUsuario { get; set; }
        public DateTime FechaGrab { get; set; }
    }
}
