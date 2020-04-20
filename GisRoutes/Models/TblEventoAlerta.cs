using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblEventoAlerta
    {
        public string IdEvento { get; set; }
        public int Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public int Dias { get; set; }
        public string Status { get; set; }
        public DateTime? FinAlerta { get; set; }
        public string IdUsuarioFin { get; set; }
    }
}
