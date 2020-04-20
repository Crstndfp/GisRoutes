using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ZtblCorrigeprecio
    {
        public string IdEnvio { get; set; }
        public string CodUbicacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Comprador { get; set; }
        public string Caja { get; set; }
        public string Transaccion { get; set; }
        public string Sku { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
