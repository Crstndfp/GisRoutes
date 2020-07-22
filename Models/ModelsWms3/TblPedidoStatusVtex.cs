using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblPedidoStatusVtex
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int CodEstado { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? FechaEcom { get; set; }
    }
}
