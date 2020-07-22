using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetOservicio
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public int IdxOrg { get; set; }
        public int Idx { get; set; }
        public string Tipo { get; set; }
        public string Sku { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioN { get; set; }
        public decimal? PrecioDesc { get; set; }
        public string Status { get; set; }
        public double? PuntosAcumulables { get; set; }
        public double? PuntosPagables { get; set; }
        public decimal? PrecioPagoPuntos { get; set; }
        public string ModoPuntos { get; set; }
        public double? PuntosAcumulados { get; set; }
        public double? PuntosPagados { get; set; }
        public string Scanner { get; set; }
    }
}
