using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblTipoUbicacion
    {
        public int CodTipo { get; set; }
        public string Nombre { get; set; }
        public string PermiteIngreso { get; set; }
        public string PermiteDespacho { get; set; }
        public string PermiteUbicacion { get; set; }
        public string PermiteAuditoria { get; set; }
        public string Danado { get; set; }
        public string Categorias { get; set; }
        public int? PrioridadDesp { get; set; }
        public string MezclaOla { get; set; }
        public string Bloqueado { get; set; }
        public string PermiteRegalos { get; set; }
    }
}
