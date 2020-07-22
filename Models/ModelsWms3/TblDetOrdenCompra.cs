using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetOrdenCompra
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int? Linea { get; set; }
        public string Sku { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public int Procesado { get; set; }
        public int Colocado { get; set; }
        public int Danado { get; set; }
        public int? CodTipoOrig { get; set; }
        public string NumDocOrig { get; set; }
        public int? LineaOrig { get; set; }
        public string Modelo { get; set; }
    }
}
