using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ZviwListadoBebes
    {
        public string IdEvento { get; set; }
        public string NombreEvento { get; set; }
        public string TiendaRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaEvento { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Email { get; set; }
        public int CodTipoCont { get; set; }
        public string Nombre { get; set; }
        public string TarjetaPrivilegio { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string ApCasada { get; set; }
    }
}
