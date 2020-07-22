using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ZtmpEventos
    {
        public string IdEvento { get; set; }
        public string Titulo { get; set; }
        public DateTime Fecharegistro { get; set; }
        public string CodUbicacion { get; set; }
        public string CodUbicacionlista { get; set; }
        public string Apellido1Novio { get; set; }
        public string Apellido2Novio { get; set; }
        public string Nombre1Novio { get; set; }
        public string Nombre2Novio { get; set; }
        public string CorreoNovio { get; set; }
        public string CelularNovio { get; set; }
        public string TelOficinaNovio { get; set; }
        public string FaxNovio { get; set; }
        public string Apellido1Novia { get; set; }
        public string Apellido2Novia { get; set; }
        public string Nombre1Novia { get; set; }
        public string Nombre2Novia { get; set; }
        public string CorreoNovia { get; set; }
        public string CelularNovia { get; set; }
        public string TelOficinaNovia { get; set; }
        public string FaxNovia { get; set; }
        public string TarjetaPrivilegio { get; set; }
        public DateTime? Fechaevento { get; set; }
        public DateTime? Fechalista { get; set; }
    }
}
