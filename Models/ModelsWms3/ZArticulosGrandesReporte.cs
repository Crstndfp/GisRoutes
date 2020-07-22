using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZArticulosGrandesReporte
    {
        public string Caja { get; set; }
        public int Transaccion { get; set; }
        public string Tienda { get; set; }
        public string Cliente { get; set; }
        public string Sku { get; set; }
        public string NombreSku { get; set; }
        public string Departamento { get; set; }
        public int Unidades { get; set; }
        public decimal? Monto { get; set; }
        public string CarPlan { get; set; }
        public string Fuente { get; set; }
        public long? StockTienda { get; set; }
        public long? StockBodega { get; set; }
    }
}
