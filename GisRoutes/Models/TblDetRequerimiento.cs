using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblDetRequerimiento
    {
        public string IdEnvio { get; set; }
        public string Sku { get; set; }
        public string Color { get; set; }
        public string CodUbicacion { get; set; }
        public string TipoLoc { get; set; }
        public string Localizacion { get; set; }
        public int Cantidad { get; set; }
        public string Status { get; set; }
        public DateTime FechaGen { get; set; }
        public string IdUsuario { get; set; }
        public DateTime? FechaConf { get; set; }
        public int? CantidadConf { get; set; }
        public string IdTraslado { get; set; }
    }
}
