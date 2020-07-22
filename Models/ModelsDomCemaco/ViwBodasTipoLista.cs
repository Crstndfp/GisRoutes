using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ViwBodasTipoLista
    {
        public string NombreEvento { get; set; }
        public DateTime? FechaEvento { get; set; }
        public string TipoLista { get; set; }
        public string CodUbicacionLista { get; set; }
        public decimal? CantidadXPrecio { get; set; }
    }
}
