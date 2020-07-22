using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblValeComb
    {
        public string NumVale { get; set; }
        public DateTime Fecha { get; set; }
        public string CodProveedor { get; set; }
        public string IdPersonal { get; set; }
        public string NumVehiculo { get; set; }
        public float Medicion { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        public string IdUsuario { get; set; }
    }
}
