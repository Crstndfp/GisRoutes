using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ViwTiempoEntrega
    {
        public string IdEnvio { get; set; }
        public string Comprador { get; set; }
        public string MailEntrega { get; set; }
        public string IdEvento { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? Fechaentrega { get; set; }
        public double? Tiempo { get; set; }
    }
}
