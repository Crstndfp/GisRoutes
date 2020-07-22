using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblResolucionDoc
    {
        public string CodEmpresa { get; set; }
        public string Resolucion { get; set; }
        public byte CodTipo { get; set; }
        public DateTime FechaAut { get; set; }
        public string Serie { get; set; }
        public int CorrelInicial { get; set; }
        public int CorrelFinal { get; set; }
        public int CorrelActual { get; set; }
        public string Status { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string ModoFe { get; set; }
    }
}
