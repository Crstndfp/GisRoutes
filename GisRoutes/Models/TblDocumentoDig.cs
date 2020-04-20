using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblDocumentoDig
    {
        public string IdDocumento { get; set; }
        public DateTime FechaGrab { get; set; }
        public string Origen { get; set; }
        public string IdOrigen { get; set; }
        public int CodTipoDoc { get; set; }
        public string Referencia { get; set; }
        public string TipoVal { get; set; }
        public string Valor { get; set; }
        public DateTime FechaDoc { get; set; }
    }
}
