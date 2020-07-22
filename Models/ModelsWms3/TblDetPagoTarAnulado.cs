using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetPagoTarAnulado
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public int Idx { get; set; }
        public string Status { get; set; }
    }
}
