using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblPedidoEntregaTda
    {
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string IdUsuario { get; set; }
        public DateTime FechaEnt { get; set; }
        public string Recibio { get; set; }
    }
}
