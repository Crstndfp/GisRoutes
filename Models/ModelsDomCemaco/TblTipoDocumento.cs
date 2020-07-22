using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblTipoDocumento
    {
        public byte CodTipo { get; set; }
        public string Nombre { get; set; }
        public string NomCorto { get; set; }
        public string IncluyeIva { get; set; }
        public string Accion { get; set; }
        public string Serie { get; set; }
        public int CorrelActual { get; set; }
    }
}
