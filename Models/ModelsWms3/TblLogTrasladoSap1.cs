using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblLogTrasladoSap1
    {
        public int CodTipoDoc { get; set; }
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public DateTime Fecha { get; set; }
        public string Status { get; set; }
        public string DatoLog { get; set; }
        public string Trasladable { get; set; }
    }
}
