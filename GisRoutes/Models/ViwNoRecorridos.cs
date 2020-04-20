using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ViwNoRecorridos
    {
        public string Tienda { get; set; }
        public string Mes { get; set; }
        public int? Año { get; set; }
        public int? CantidadDeRecorridos { get; set; }
    }
}
