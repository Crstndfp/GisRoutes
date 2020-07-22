using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetOlaAudit
    {
        public string NumOla { get; set; }
        public int Idx { get; set; }
        public int IdxAudit { get; set; }
        public int CantidadAudit { get; set; }
        public string Tarima { get; set; }
        public string IdAuditor { get; set; }
        public DateTime FechaAuditoria { get; set; }
        public DateTime? FechaTarimaSap { get; set; }
        public string MsgError { get; set; }
    }
}
