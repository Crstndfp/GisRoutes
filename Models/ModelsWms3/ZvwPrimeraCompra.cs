using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZvwPrimeraCompra
    {
        public string Cliente { get; set; }
        public string NombreCliente { get; set; }
        public string EmailCliente { get; set; }
        public int? PrimeraCompra { get; set; }
        public int? PrimeraCompraNoBodas { get; set; }
    }
}
