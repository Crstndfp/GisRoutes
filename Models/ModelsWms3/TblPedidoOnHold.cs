using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblPedidoOnHold
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public DateTime FechaBloqueo { get; set; }
        public string IdUsrBloqueo { get; set; }
        public DateTime? FechaLiber { get; set; }
        public string IdUsrLiber { get; set; }
    }
}
