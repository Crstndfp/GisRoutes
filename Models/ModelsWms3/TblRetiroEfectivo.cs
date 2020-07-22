using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblRetiroEfectivo
    {
        public string NumRetiro { get; set; }
        public string NumOperacion { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
