using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblSeguimiento
    {
        public Guid IdSeguimiento { get; set; }
        public string IdEvento { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public string Destinatarios { get; set; }
        public string Tipo { get; set; }
        public byte[] DatosAct { get; set; }
        public string Status { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public string IdUsuarioConf { get; set; }
        public DateTime? FechaConf { get; set; }
    }
}
