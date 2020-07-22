using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetPedidoCupon
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public int Tcupon { get; set; }
        public int Cupones { get; set; }
        public decimal Valor { get; set; }
    }
}
