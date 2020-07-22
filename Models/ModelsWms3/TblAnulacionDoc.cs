using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblAnulacionDoc
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public int? CodRazon { get; set; }
        public string Descripcion { get; set; }
    }
}
