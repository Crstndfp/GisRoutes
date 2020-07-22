using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblCaja
    {
        public string IdCaja { get; set; }
        public string Status { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public string Version { get; set; }
        public int? CodPerfil { get; set; }
        public string CodTienda { get; set; }
        public int? CorrelTrans { get; set; }
        public string Scanner { get; set; }
        public int? IdxFel { get; set; }
        public int? DispositivoFel { get; set; }
    }
}
