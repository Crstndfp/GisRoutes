using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class AcreditacionesPrivilegio
    {
        public string IdEvento { get; set; }
        public DateTime? FechaEvento { get; set; }
        public string Titulo { get; set; }
        public string NombreNovio1 { get; set; }
        public string NombreNovio2 { get; set; }
        public string ApellidoNovio1 { get; set; }
        public string ApellidoNovio2 { get; set; }
        public string NombreNovia1 { get; set; }
        public string NombreNovia2 { get; set; }
        public string ApellidoNovia1 { get; set; }
        public string ApellidoNovia2 { get; set; }
        public string TarjetaPrivilegio { get; set; }
        public string CodUbicacion { get; set; }
        public int? Cantidad { get; set; }
        public decimal? MontoEnVentas { get; set; }
    }
}
