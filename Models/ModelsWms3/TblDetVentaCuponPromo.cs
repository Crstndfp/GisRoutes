using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetVentaCuponPromo
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public string CodCupon { get; set; }
        public int Cantidad { get; set; }
    }
}
