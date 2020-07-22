using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblLogDevolucionManual
    {
        public string TipoDv { get; set; }
        public string SerieDv { get; set; }
        public int NumeroDv { get; set; }
        public decimal Monto { get; set; }
        public string Status { get; set; }
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public string Supervisor { get; set; }
        public string Autorizador { get; set; }
        public DateTime? FechaAut { get; set; }
        public string Observaciones { get; set; }
    }
}
