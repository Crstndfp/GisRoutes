using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblAnalisisPedido
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string CodCentroDist { get; set; }
        public string Sku { get; set; }
        public int Existencia { get; set; }
        public int Solicitado { get; set; }
        public int? DespachableBase { get; set; }
        public int? Despachable { get; set; }
        public int? Reservado { get; set; }
    }
}
