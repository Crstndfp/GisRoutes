using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class Z20190927TblOla
    {
        public string NumOla { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public DateTime? Procesada { get; set; }
        public string Status { get; set; }
        public string ReqAuditoria { get; set; }
        public string ModoContab { get; set; }
        public string ModoCierre { get; set; }
        public string CodCentroDist { get; set; }
    }
}
