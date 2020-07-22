using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetPedidoDesc
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string CodCupon { get; set; }
        public decimal Valor { get; set; }
    }
}
