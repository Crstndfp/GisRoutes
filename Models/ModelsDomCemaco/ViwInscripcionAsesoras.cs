using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ViwInscripcionAsesoras
    {
        public string IdAsesora { get; set; }
        public string NombreAsesora { get; set; }
        public string Tienda { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int? CantidadEventos { get; set; }
    }
}
