using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class CrgGrupoArticulo
    {
        public string CodGrupo { get; set; }
        public string Nombre { get; set; }
        public string CodPadre { get; set; }
        public int? Nivel { get; set; }
    }
}
