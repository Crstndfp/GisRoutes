using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ViwEnviosPosterioresBodasLiquidadas
    {
        public string IdEvento { get; set; }
        public string Evento { get; set; }
        public DateTime? FechaEvento { get; set; }
        public int? AñoEvento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? AñoRegistro { get; set; }
        public string TarjetaPrivilegio { get; set; }
        public string Tienda { get; set; }
        public string TipoLista { get; set; }
        public string Dirección { get; set; }
        public string Zona { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public DateTime? FechaLiquidacion { get; set; }
        public string Telefono { get; set; }
        public string NombreNovio1 { get; set; }
        public string NombreNovio2 { get; set; }
        public string ApellidoNovio1 { get; set; }
        public string ApellidoNovio2 { get; set; }
        public string OrdenH { get; set; }
        public string RegistroH { get; set; }
        public string EMailNovio { get; set; }
        public string TelefonoNovio { get; set; }
        public string TelefonoOfiNovio { get; set; }
        public string CelNovio { get; set; }
        public string NombreNovia1 { get; set; }
        public string NombreNovia2 { get; set; }
        public string ApellidoNovia1 { get; set; }
        public string ApellidoNovia2 { get; set; }
        public string OrdenM { get; set; }
        public string RegistroM { get; set; }
        public string EMailNovia { get; set; }
        public string TelefonoNovia { get; set; }
        public string TelefonoOfiNovia { get; set; }
        public string CelNovia { get; set; }
        public int? CantidadEnvios { get; set; }
        public int? CantidadRegalos { get; set; }
        public int? CantidadUnidades { get; set; }
        public decimal? CantidadXPrecio { get; set; }
        public string CodUbicacionLiq { get; set; }
        public decimal? PuntosAcreditosBodasInscrip { get; set; }
    }
}
