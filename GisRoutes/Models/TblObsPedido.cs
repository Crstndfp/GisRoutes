using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblObsPedido
    {
        public string IdPedido { get; set; }
        public int Ind { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public string Observaciones { get; set; }
    }
}
