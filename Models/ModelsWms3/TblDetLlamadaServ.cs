using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetLlamadaServ
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int Linea { get; set; }
        public string Sku { get; set; }
        public string Skufact { get; set; }
        public decimal? PrecioBase { get; set; }
        public decimal Precio { get; set; }
        public decimal? PrecioOrig { get; set; }
        public int Cantidad { get; set; }
        public string Accion { get; set; }
        public string Skureemplazo { get; set; }
    }
}
