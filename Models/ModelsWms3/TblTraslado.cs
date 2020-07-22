using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblTraslado
    {
        public string NumTraslado { get; set; }
        public string CodTienda { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public string Status { get; set; }
    }
}
