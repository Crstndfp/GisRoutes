using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ViwTrasladoPendiente
    {
        public string IdTraslado { get; set; }
        public string CodUbicacion { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Status { get; set; }
        public string IdUsuarioRec { get; set; }
        public DateTime? FechaRecep { get; set; }
    }
}
