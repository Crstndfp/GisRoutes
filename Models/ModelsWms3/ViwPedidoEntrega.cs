using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ViwPedidoEntrega
    {
        public string PedidoLec { get; set; }
        public string Pedido { get; set; }
        public DateTime Fecha { get; set; }
        public string Status { get; set; }
        public string NumEmpaque { get; set; }
        public int? Tguia { get; set; }
        public string Transporte { get; set; }
        public string Guia { get; set; }
        public DateTime FechaEmpaque { get; set; }
        public string Factura { get; set; }
        public DateTime? FechaEnt { get; set; }
        public string Recibio { get; set; }
    }
}
