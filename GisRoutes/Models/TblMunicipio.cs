﻿using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblMunicipio
    {
        public string CodPais { get; set; }
        public byte CodDepartamento { get; set; }
        public byte CodMunicipio { get; set; }
        public string Nombre { get; set; }
        public string NomCorto { get; set; }
    }
}
