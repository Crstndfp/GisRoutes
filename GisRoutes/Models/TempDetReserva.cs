using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TempDetReserva
    {
        public int NumConex { get; set; }
        public string Sku { get; set; }
        public string Color { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
