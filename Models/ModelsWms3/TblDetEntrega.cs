using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetEntrega
    {
        public string NumEntrega { get; set; }
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int Paquetes { get; set; }
    }
}
