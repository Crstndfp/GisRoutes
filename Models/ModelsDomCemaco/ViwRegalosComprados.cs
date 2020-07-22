using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ViwRegalosComprados
    {
        public string IdEvento { get; set; }
        public string Titulo { get; set; }
        public string IdEnvio { get; set; }
        public string Sku { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal? CantXPrecio { get; set; }
        public string Comprador { get; set; }
        public DateTime Fecha { get; set; }
        public string Status { get; set; }
    }
}
