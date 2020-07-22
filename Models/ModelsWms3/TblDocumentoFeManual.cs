using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDocumentoFeManual
    {
        public string CodTipo { get; set; }
        public string CodTienda { get; set; }
        public string IdCaja { get; set; }
        public int? Transaccion { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
        public string Status { get; set; }
        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public string Idtributario { get; set; }
        public string CodCliente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CodMoneda { get; set; }
        public decimal? TipoCambio { get; set; }
    }
}
