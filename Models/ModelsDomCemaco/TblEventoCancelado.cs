using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblEventoCancelado
    {
        public string IdEvento { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public string CanceladoPor { get; set; }
    }
}
