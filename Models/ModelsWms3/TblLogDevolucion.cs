using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblLogDevolucion
    {
        public string SerieDv { get; set; }
        public string NumeroDv { get; set; }
        public string TipoDv { get; set; }
        public string Accion { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public int CodRazon { get; set; }
        public string Observaciones { get; set; }
    }
}
