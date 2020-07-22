using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDocumentoClSat
    {
        public string CodTienda { get; set; }
        public int CodTipo { get; set; }
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public string Serie { get; set; }
        public int Numero { get; set; }
        public DateTime? Fecha { get; set; }
        public string Status { get; set; }
        public string NumDocumento { get; set; }
        public string Cae { get; set; }
        public string PedidoSap { get; set; }
    }
}
