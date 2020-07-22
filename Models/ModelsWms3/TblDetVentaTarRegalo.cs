using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetVentaTarRegalo
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public int Idx { get; set; }
        public string Tarjeta { get; set; }
        public decimal Monto { get; set; }
        public int? CodTipo { get; set; }
    }
}
