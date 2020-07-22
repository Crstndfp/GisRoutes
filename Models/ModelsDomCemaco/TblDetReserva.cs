using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblDetReserva
    {
        public string IdReserva { get; set; }
        public string Sku { get; set; }
        public string Color { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
