using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetAportacion
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public int CodAportacion { get; set; }
        public string CodMoneda { get; set; }
        public decimal? MontoOrg { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? Monto { get; set; }
    }
}
