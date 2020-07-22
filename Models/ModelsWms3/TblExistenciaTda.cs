using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblExistenciaTda
    {
        public string Sku { get; set; }
        public string CodUbicacion { get; set; }
        public int Existencia { get; set; }
        public int? Consignado { get; set; }
        public int? Transito { get; set; }
        public int? Reservado { get; set; }
    }
}
