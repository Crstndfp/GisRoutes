using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblTipoDocumento
    {
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string Nombre { get; set; }
        public string NomCorto { get; set; }
        public string Serie { get; set; }
        public double? CorrelActual { get; set; }
        public string Impresora { get; set; }
    }
}
