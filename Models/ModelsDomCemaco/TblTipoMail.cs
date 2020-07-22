using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblTipoMail
    {
        public int CodTipo { get; set; }
        public int CodTipoEvento { get; set; }
        public string Nombre { get; set; }
        public string Default { get; set; }
        public string Status { get; set; }
        public string Automatico { get; set; }
        public string ServidorSmtp { get; set; }
        public string PuertoSmtp { get; set; }
        public string Remitente { get; set; }
        public string PwdRemitente { get; set; }
        public string RemitenteReal { get; set; }
        public int? Frecuencia { get; set; }
        public int? Registros { get; set; }
    }
}
