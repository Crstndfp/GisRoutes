using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDocWmsPos
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public string IdAsociado { get; set; }
        public string Tarjeta { get; set; }
    }
}
