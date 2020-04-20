using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblOrdenMant
    {
        public string NumOrden { get; set; }
        public DateTime Fecha { get; set; }
        public string CodProveedor { get; set; }
        public string IdPersonal { get; set; }
        public string NumVehiculo { get; set; }
        public float Medicion { get; set; }
        public double Total { get; set; }
        public DateTime OutDel { get; set; }
        public DateTime OutAl { get; set; }
        public string IdUsuario { get; set; }
        public string Fallas { get; set; }
        public string Status { get; set; }
    }
}
