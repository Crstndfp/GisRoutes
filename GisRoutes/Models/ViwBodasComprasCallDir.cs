using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ViwBodasComprasCallDir
    {
        public string Evento { get; set; }
        public string NombreNovio1 { get; set; }
        public string NombreNovio2 { get; set; }
        public string ApellidoNovio1 { get; set; }
        public string ApellidoNovio2 { get; set; }
        public string EMailNovio { get; set; }
        public string TelefonoNovio { get; set; }
        public string TelefonoOfiNovio { get; set; }
        public string CelNovio { get; set; }
        public string DirecNovio { get; set; }
        public string NombreNovia1 { get; set; }
        public string NombreNovia2 { get; set; }
        public string ApellidoNovia1 { get; set; }
        public string ApellidoNovia2 { get; set; }
        public string EMailNovia { get; set; }
        public string TelefonoNovia { get; set; }
        public string TelefonoOfiNovia { get; set; }
        public string CelNovia { get; set; }
        public string DirecNovia { get; set; }
        public DateTime? FechaEvento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string TarjetaPrivilegio { get; set; }
    }
}
