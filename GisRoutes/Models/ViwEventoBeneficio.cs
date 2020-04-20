using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ViwEventoBeneficio
    {
        public string IdEvento { get; set; }
        public string Titulo { get; set; }
        public DateTime? FechaEvento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Novio { get; set; }
        public string Novia { get; set; }
        public decimal Acumulado { get; set; }
        public string Status { get; set; }
        public string NomStatus { get; set; }
        public string Beneficios { get; set; }
        public DateTime? Entrega { get; set; }
        public string Tienda { get; set; }
        public string Certificado { get; set; }
        public decimal Monto { get; set; }
        public string Hotel { get; set; }
        public string Cena { get; set; }
        public string Asesora { get; set; }
    }
}
