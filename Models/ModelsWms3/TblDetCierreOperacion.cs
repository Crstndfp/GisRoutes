using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetCierreOperacion
    {
        public string NumOperacion { get; set; }
        public string CodMoneda { get; set; }
        public int? CodForma { get; set; }
        public int? CodAsociado { get; set; }
        public int? Cantidad { get; set; }
        public decimal MontoOrg { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal Monto { get; set; }
        public decimal? MontoAct { get; set; }
        public string IdUsuarioAct { get; set; }
    }
}
