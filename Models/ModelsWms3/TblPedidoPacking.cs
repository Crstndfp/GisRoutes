using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblPedidoPacking
    {
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? FechaImp { get; set; }
        public string IdUsrImp { get; set; }
    }
}
