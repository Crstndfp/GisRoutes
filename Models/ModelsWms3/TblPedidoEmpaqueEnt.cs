using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblPedidoEmpaqueEnt
    {
        public string NumEmpaque { get; set; }
        public DateTime FechaEnt { get; set; }
        public string Recibio { get; set; }
        public DateTime? FechaPrimeraEntrega { get; set; }
    }
}
