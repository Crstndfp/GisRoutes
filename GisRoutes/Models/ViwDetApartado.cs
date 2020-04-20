using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ViwDetApartado
    {
        public string IdEnvio { get; set; }
        public string Sku { get; set; }
        public string Color { get; set; }
        public string Descripcion { get; set; }
        public string Ambiente { get; set; }
        public int? Cantidad { get; set; }
    }
}
