using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblEventoActualizado
    {
        public string IdEvento { get; set; }
        public DateTime Fecha { get; set; }
        public string Status { get; set; }
        public string Origen { get; set; }
        public string EmailAnt { get; set; }
        public string EmailNuevo { get; set; }
        public string Host { get; set; }
        public string UsrDb { get; set; }
        public string TipoAct { get; set; }
    }
}
