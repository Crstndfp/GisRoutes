using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblLogMailEvento
    {
        public string IdEvento { get; set; }
        public int? CodTipo { get; set; }
        public DateTime? Fecha { get; set; }
        public string Status { get; set; }
        public string Destinatario { get; set; }
    }
}
