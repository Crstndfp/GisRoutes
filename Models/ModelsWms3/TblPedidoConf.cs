using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblPedidoConf
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
    }
}
