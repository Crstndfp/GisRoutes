using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetVentaComboGrp
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public int Idx { get; set; }
        public int IdxCombo { get; set; }
        public string CodGrupo { get; set; }
        public decimal MontoUtilizado { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Modo { get; set; }
    }
}
