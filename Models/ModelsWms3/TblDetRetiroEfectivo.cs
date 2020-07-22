using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetRetiroEfectivo
    {
        public string NumRetiro { get; set; }
        public string CodMoneda { get; set; }
        public decimal Monto { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal MontoLocal { get; set; }
    }
}
