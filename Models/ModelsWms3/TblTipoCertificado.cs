using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblTipoCertificado
    {
        public int CodTipo { get; set; }
        public string Nombre { get; set; }
        public string CodSap { get; set; }
        public string Status { get; set; }
        public string TextoFact { get; set; }
        public string CodCupon { get; set; }
        public int? CodFormaPago { get; set; }
        public decimal? MontoFijo { get; set; }
        public string UtilizaRango { get; set; }
    }
}
