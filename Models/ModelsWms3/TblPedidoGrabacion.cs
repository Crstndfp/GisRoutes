using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblPedidoGrabacion
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public string ModoIngreso { get; set; }
    }
}
