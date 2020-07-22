using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class CrgDetMovBodega
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int? LineaOrig { get; set; }
        public string Sku { get; set; }
        public int Cantidad { get; set; }
        public string CodMedida { get; set; }
        public int UnidMed { get; set; }
        public int Unidades { get; set; }
        public string IdUbicOrig { get; set; }
        public string IdUbicDest { get; set; }
        public string IdUsuario { get; set; }
        public DateTime? FechaOp { get; set; }
        public string DocSap { get; set; }
        public DateTime? FechaSap { get; set; }
    }
}
