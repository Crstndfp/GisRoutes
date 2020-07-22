using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetConteoInventario
    {
        public string NumDocumento { get; set; }
        public string IdUbicacion { get; set; }
        public string Sku { get; set; }
        public int? Existencia { get; set; }
        public int? Conteo { get; set; }
        public string IdUsuarioCont { get; set; }
        public int? ConteoConf { get; set; }
        public string IdUsuarioConf { get; set; }
        public int? ExistenciaConf { get; set; }
        public decimal? Costo { get; set; }
        public DateTime? FechaConteo { get; set; }
        public DateTime? FechaReConteo { get; set; }
    }
}
