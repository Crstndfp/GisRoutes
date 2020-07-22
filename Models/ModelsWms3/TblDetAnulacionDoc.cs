using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetAnulacionDoc
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public string SerieDv { get; set; }
        public string NumeroDv { get; set; }
        public string TipoDv { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public int? CodRazon { get; set; }
        public string Descripcion { get; set; }
    }
}
