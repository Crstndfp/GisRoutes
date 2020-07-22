using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetVentaEncuesta
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public string CodEncuesta { get; set; }
        public int CodPregunta { get; set; }
        public int CodRespuesta { get; set; }
        public string DescRespuesta { get; set; }
    }
}
