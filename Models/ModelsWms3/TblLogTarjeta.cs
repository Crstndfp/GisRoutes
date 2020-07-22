using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblLogTarjeta
    {
        public string CodTienda { get; set; }
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public int CodAutorizador { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public string Tipo { get; set; }
        public DateTime? FechaRespuesta { get; set; }
        public string TrackRespuesta { get; set; }
        public int? Correlativo { get; set; }
        public string TagImpresion { get; set; }
    }
}
