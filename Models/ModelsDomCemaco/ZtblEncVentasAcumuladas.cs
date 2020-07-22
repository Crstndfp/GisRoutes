using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ZtblEncVentasAcumuladas
    {
        public string CodTienda { get; set; }
        public string Caja { get; set; }
        public string Transaccion { get; set; }
        public decimal? Precio { get; set; }
        public int? Articulos { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Año { get; set; }
        public string IdEvento { get; set; }
    }
}
