using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblVisita
    {
        public string IdAsociado { get; set; }
        public DateTime Fecha { get; set; }
        public string CodTienda { get; set; }
        public string Status { get; set; }
    }
}
