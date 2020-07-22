using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblAutorizadorTarjeta
    {
        public int CodAutorizador { get; set; }
        public string Nombre { get; set; }
        public string CodSap { get; set; }
        public decimal? Valormax { get; set; }
        public string TextoSinFirma { get; set; }
        public string TextoConFirma { get; set; }
        public int? CodTipo { get; set; }
        public string TextoCompra { get; set; }
        public int? ModoAnulacion { get; set; }
        public string CodSapcuota { get; set; }
    }
}
