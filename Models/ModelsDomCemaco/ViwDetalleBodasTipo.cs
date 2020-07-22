using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ViwDetalleBodasTipo
    {
        public string NombreDelEvento { get; set; }
        public DateTime? FechaEvento { get; set; }
        public int CodTipoLista { get; set; }
        public string CodUbicacionLista { get; set; }
        public string Descripción { get; set; }
    }
}
