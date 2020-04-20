using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ZtblAnalisisDatos2018
    {
        public string IdEvento { get; set; }
        public string Titulo { get; set; }
        public string Sku { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal? MontoTotal { get; set; }
    }
}
