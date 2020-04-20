using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ZtmpdetListaregalos
    {
        public string IdLista { get; set; }
        public string Sku { get; set; }
        public string Color { get; set; }
        public string Ean { get; set; }
        public string Descripcion { get; set; }
        public string Ambiente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string UnidMed { get; set; }
        public int Solicitado { get; set; }
        public int Comprado { get; set; }
        public decimal Precio { get; set; }
    }
}
