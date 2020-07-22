using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetAutPago
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public int Idx { get; set; }
        public int? IdxP { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public int? IdxOrgImp { get; set; }
        public string Banda { get; set; }
    }
}
