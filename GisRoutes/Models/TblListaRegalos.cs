using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblListaRegalos
    {
        public string IdLista { get; set; }
        public string IdEvento { get; set; }
        public DateTime? FechaRecorrido { get; set; }
        public string CodUbicacion { get; set; }
        public string IdPersonal { get; set; }
    }
}
