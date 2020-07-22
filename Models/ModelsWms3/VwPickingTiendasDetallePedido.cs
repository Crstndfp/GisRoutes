using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class VwPickingTiendasDetallePedido
    {
        public string Pedido { get; set; }
        public string NumPedido { get; set; }
        public string Titulo { get; set; }
        public string Departamento { get; set; }
        public string Sku { get; set; }
        public int Cantidad { get; set; }
        public string UrlFoto { get; set; }
        public string UrlPdp { get; set; }
    }
}
