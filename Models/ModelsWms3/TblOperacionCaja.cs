using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblOperacionCaja
    {
        public string NumOperacion { get; set; }
        public string CodTienda { get; set; }
        public string IdCaja { get; set; }
        public string IdUsuario { get; set; }
        public DateTime FechaApertura { get; set; }
        public string IdUsuarioCierre { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string Status { get; set; }
    }
}
