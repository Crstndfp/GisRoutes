using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDocRegenerado
    {
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string Original { get; set; }
        public string Nuevo { get; set; }
    }
}
