using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ViwDetRegalosComprados
    {
        public string IdEvento { get; set; }
        public DateTime Fecha { get; set; }
        public string Sku { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Comprador { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string Tienda { get; set; }
    }
}
