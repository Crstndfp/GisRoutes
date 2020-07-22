using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblTrxTrasladada
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public DateTime Fecha { get; set; }
        public string ServidorDest { get; set; }
        public string Dbdest { get; set; }
    }
}
