using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetPago
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public int Idx { get; set; }
        public int Tipo { get; set; }
        public string CodMoneda { get; set; }
        public decimal? MontoOrg { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? Monto { get; set; }
        public decimal? Cambio { get; set; }
        public int? CodBanco { get; set; }
        public string Cuenta { get; set; }
        public string Documento { get; set; }
        public string Referencia { get; set; }
        public string Autorizacion { get; set; }
        public int? Auditoria { get; set; }
        public string Afiliacion { get; set; }
        public string FechaVencimiento { get; set; }
        public string Propietario { get; set; }
        public string Documento2 { get; set; }
        public string Identificacion { get; set; }
        public string ModoPago { get; set; }
    }
}
