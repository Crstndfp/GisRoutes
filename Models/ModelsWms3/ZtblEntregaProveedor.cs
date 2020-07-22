using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZtblEntregaProveedor
    {
        public int IdEntregaProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public string IdPedido { get; set; }
        public string IdOrden { get; set; }
        public string IdResultado { get; set; }
        public string PerEntrega { get; set; }
        public string PerRecibe { get; set; }
        public string Comentario { get; set; }
        public string Fotos { get; set; }
    }
}
