using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZviwRequerimientosCentroDistB001
    {
        public string Pedido { get; set; }
        public DateTime FechaLec { get; set; }
        public string CentroDistribucion { get; set; }
        public string Sku { get; set; }
        public string Tienda { get; set; }
        public int Existencia { get; set; }
        public int Solicitado { get; set; }
        public int? Despachable { get; set; }
    }
}
