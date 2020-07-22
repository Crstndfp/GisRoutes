using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblTipoMailZdesk
    {
        public int CodTipo { get; set; }
        public string Nombre { get; set; }
        public string Destinatario { get; set; }
        public string CopiaOculta { get; set; }
        public string Status { get; set; }
    }
}
