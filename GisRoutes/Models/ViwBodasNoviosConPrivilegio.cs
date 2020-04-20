using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ViwBodasNoviosConPrivilegio
    {
        public string IdEvento { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUbicacion { get; set; }
        public string CodUbicacionLista { get; set; }
        public string Apellido1Novio { get; set; }
        public string Apellido2Novio { get; set; }
        public string Nombre1Novio { get; set; }
        public string Nombre2Novio { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string TelOficina { get; set; }
        public string Fax { get; set; }
        public string Apellido1Novia { get; set; }
        public string Apellido2Novia { get; set; }
        public string Nombre1Novia { get; set; }
        public string Nombre2Novia { get; set; }
        public string Expr1 { get; set; }
        public string Expr2 { get; set; }
        public string Expr3 { get; set; }
        public string Expr4 { get; set; }
        public string TarjetaPrivilegio { get; set; }
        public string IdAsociado { get; set; }
        public string NombresPrivi { get; set; }
        public string ApellidosPrivi { get; set; }
        public string NombreTarjetaPrivi { get; set; }
        public DateTime? FechaEvento { get; set; }
        public DateTime? FechaLista { get; set; }
    }
}
