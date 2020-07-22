using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ViwAcumulacionRegalo
    {
        public string IdEvento { get; set; }
        public string NombreEvento { get; set; }
        public string Tienda { get; set; }
        public string NoEnvio { get; set; }
        public string Sku { get; set; }
        public string Descripcion { get; set; }
        public decimal? CantidadXprecio { get; set; }
        public decimal? CantXprecio10 { get; set; }
    }
}
