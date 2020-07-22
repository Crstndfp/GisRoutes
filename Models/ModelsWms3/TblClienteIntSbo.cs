using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblClienteIntSbo
    {
        public string CodEmpresa { get; set; }
        public string CodEmpCliente { get; set; }
        public string CodCliente { get; set; }
        public string CodProveedor { get; set; }
        public int? SerieFactSbo { get; set; }
        public string WareHouse { get; set; }
    }
}
