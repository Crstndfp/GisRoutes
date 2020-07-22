using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetCobro
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public string CodMoneda { get; set; }
        public int? CodBanco { get; set; }
        public string Cuenta { get; set; }
        public string Documento { get; set; }
        public string Afiliacion { get; set; }
        public string FechaVencimiento { get; set; }
        public string Propietario { get; set; }
        public string Documento2 { get; set; }
        public string Identificacion { get; set; }
    }
}
