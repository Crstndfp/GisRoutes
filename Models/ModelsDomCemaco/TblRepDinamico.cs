﻿using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblRepDinamico
    {
        public int CodReporte { get; set; }
        public string Nombre { get; set; }
        public string Query { get; set; }
        public string CodAplicacion { get; set; }
    }
}
