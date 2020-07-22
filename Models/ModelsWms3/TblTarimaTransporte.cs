using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblTarimaTransporte
    {
        public string Tarima { get; set; }
        public string Transporte { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
    }
}
