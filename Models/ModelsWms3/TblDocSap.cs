using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDocSap
    {
        public string CodTipo { get; set; }
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public string FacturaSap { get; set; }
        public string PagoSap { get; set; }
        public DateTime? FechaAct { get; set; }
    }
}
