using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ViwAnalisisBodas
    {
        public string IdEvento { get; set; }
        public string Titulo { get; set; }
        public int? CantInvitados { get; set; }
        public decimal Precio { get; set; }
        public string FechaEvento { get; set; }
    }
}
