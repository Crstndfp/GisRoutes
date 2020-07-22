using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDocumentoClSatfelcontingencia
    {
        public string CodTienda { get; set; }
        public int CodTipo { get; set; }
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public string NumContingencia { get; set; }
        public DateTime Fecha { get; set; }
    }
}
