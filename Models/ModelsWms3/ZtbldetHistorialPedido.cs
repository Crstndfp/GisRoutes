using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZtbldetHistorialPedido
    {
        public int? CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string Tipo { get; set; }
        public DateTime? Fecha { get; set; }
        public TimeSpan? Hora { get; set; }
        public string Texto { get; set; }
    }
}
