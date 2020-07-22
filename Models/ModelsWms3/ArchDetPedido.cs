using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ArchDetPedido
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int? Linea { get; set; }
        public string Sku { get; set; }
        public string Skufact { get; set; }
        public decimal? PrecioBase { get; set; }
        public decimal Precio { get; set; }
        public decimal? PrecioOrig { get; set; }
        public int Cantidad { get; set; }
        public int Despachable { get; set; }
        public int Listo { get; set; }
        public int? Auditado { get; set; }
        public string Tipo { get; set; }
    }
}
