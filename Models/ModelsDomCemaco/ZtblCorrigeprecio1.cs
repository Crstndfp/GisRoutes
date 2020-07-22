using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ZtblCorrigeprecio1
    {
        public string IdEnvio { get; set; }
        public string Caja { get; set; }
        public string Transaccion { get; set; }
        public string Idtributario { get; set; }
        public string Nombre { get; set; }
        public string StatusFact { get; set; }
        public decimal? Preciodesc { get; set; }
        public string Sku { get; set; }
        public string StatusDet { get; set; }
    }
}
