using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetVentaCuponSocio
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public string CodCupon { get; set; }
        public int? Numero { get; set; }
    }
}
