using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ViwDocumentoFiscal
    {
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public decimal? Descuento { get; set; }
        public decimal SubTotal { get; set; }
        public decimal PagosAfectanTotal { get; set; }
        public decimal? Total { get; set; }
        public string FormaPagoAfecta { get; set; }
    }
}
