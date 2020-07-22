using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblLogTrasladoSat
    {
        public string CodTienda { get; set; }
        public int CodTipoDoc { get; set; }
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string DatoLog { get; set; }
    }
}
