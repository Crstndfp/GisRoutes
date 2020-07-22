using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDocumentoClSap
    {
        public string CodTienda { get; set; }
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public DateTime? Fecha { get; set; }
        public string Status { get; set; }
    }
}
