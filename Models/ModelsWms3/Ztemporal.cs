using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class Ztemporal
    {
        public string Tienda { get; set; }
        public string Fecha { get; set; }
        public string Caja { get; set; }
        public int Transaccion { get; set; }
        public string Serie { get; set; }
        public string NumFact { get; set; }
        public string Estado { get; set; }
        public decimal Total { get; set; }
        public int CorrPago { get; set; }
        public string FormaPago { get; set; }
        public string Moneda { get; set; }
        public decimal? MontoFormaPago { get; set; }
        public decimal? TipoCambio { get; set; }
        public string Empresa { get; set; }
        public string Documento { get; set; }
        public string Autorizacion { get; set; }
    }
}
