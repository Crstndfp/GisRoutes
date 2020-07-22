using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblLogTrxTraslado
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public DateTime Fecha { get; set; }
        public string ServidorDest { get; set; }
        public string Dbdest { get; set; }
        public string Mensaje { get; set; }
    }
}
