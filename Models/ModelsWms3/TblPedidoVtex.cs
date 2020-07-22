using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblPedidoVtex
    {
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string Secuencia { get; set; }
        public int? Paquetes { get; set; }
        public string Carrier { get; set; }
        public string Dock { get; set; }
        public int? CodEstado { get; set; }
    }
}
