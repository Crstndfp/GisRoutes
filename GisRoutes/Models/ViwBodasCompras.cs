using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ViwBodasCompras
    {
        public string NombreDelEvento { get; set; }
        public string TipoLista { get; set; }
        public int? Cantidad { get; set; }
        public decimal? CantidadXPrecio { get; set; }
        public DateTime? FechaEvento { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
