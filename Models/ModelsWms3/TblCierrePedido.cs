using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblCierrePedido
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public string Razon { get; set; }
        public string Status { get; set; }
        public DateTime? FechaEcom { get; set; }
        public int? CodRazon { get; set; }
    }
}
