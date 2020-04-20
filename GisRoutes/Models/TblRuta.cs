using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblRuta
    {
        public string IdRuta { get; set; }
        public DateTime Fecha { get; set; }
        public string IdPersonal { get; set; }
        public string NumVehiculo { get; set; }
        public float MedicionIni { get; set; }
        public float MedicionFin { get; set; }
        public string Status { get; set; }
        public string IdUsuario { get; set; }
        public string Tipo { get; set; }
        public string CodCentroDist { get; set; }
    }
}
