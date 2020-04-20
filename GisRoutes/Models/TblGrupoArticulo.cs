using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblGrupoArticulo
    {
        public string CodGrupo { get; set; }
        public string Nombre { get; set; }
        public string CodPadre { get; set; }
        public int? Nivel { get; set; }
    }
}
