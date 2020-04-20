using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblEventoCertRegalo
    {
        public string IdEvento { get; set; }
        public string NombreNc { get; set; }
        public string Nitnc { get; set; }
        public string Certificado { get; set; }
        public DateTime? FechaLiq { get; set; }
        public string CodUbicacionLiq { get; set; }
        public string IdUsuarioLiq { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string CodUbicacionEnt { get; set; }
        public string IdUsuarioEnt { get; set; }
        public string CertificadoBenef { get; set; }
        public DateTime? FechaCerfBenef { get; set; }
        public string IdUsuarioCertBenef { get; set; }
        public string IdCajaLiq { get; set; }
        public int? TransaccionLiq { get; set; }
        public decimal? TotalRegalos { get; set; }
        public string CodBeneficioH { get; set; }
        public string CuponH { get; set; }
        public string CodBeneficioC { get; set; }
        public string CuponC { get; set; }
    }
}
