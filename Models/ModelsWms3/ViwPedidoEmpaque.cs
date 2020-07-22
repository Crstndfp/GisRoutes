using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ViwPedidoEmpaque
    {
        public string NumEmpaque { get; set; }
        public int? Tguia { get; set; }
        public string Guia { get; set; }
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public int Bultos { get; set; }
        public string Licencia { get; set; }
        public string IdEmbalador { get; set; }
        public string Puerta { get; set; }
        public string DocSap { get; set; }
        public DateTime? FechaSap { get; set; }
        public int Tdped { get; set; }
        public string Pedido { get; set; }
    }
}
