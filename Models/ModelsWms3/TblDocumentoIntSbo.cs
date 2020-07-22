using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDocumentoIntSbo
    {
        public string CodEmpresa { get; set; }
        public int? CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string DocSap { get; set; }
        public DateTime? Fecha { get; set; }
        public string CodEmpCliente { get; set; }
    }
}
