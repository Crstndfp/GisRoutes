using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetVentaCombo
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public int Idx { get; set; }
        public int IdxCombo { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Tipo { get; set; }
    }
}
