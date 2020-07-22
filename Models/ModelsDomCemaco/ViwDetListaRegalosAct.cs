using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ViwDetListaRegalosAct
    {
        public string IdEvento { get; set; }
        public string Sku { get; set; }
        public string Color { get; set; }
        public string Ean { get; set; }
        public string Descripcion { get; set; }
        public string Ambiente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Unidmed { get; set; }
        public int? Solicitado { get; set; }
        public int? Comprado { get; set; }
        public decimal? Precio { get; set; }
    }
}
