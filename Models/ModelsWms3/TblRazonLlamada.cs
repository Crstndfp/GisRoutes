using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblRazonLlamada
    {
        public int CodRazon { get; set; }
        public string Descripcion { get; set; }
        public string ReqRecepcion { get; set; }
        public string Status { get; set; }
        public int? CodRazonNc { get; set; }
    }
}
