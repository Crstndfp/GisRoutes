using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class EliminarActualizarRegistros
    {
        public double? Id { get; set; }
        public string PersonaEntrega { get; set; }
        public string PersonaRecibe { get; set; }
        public string TipoGuia { get; set; }
        public double? NumeroGuia { get; set; }
        public string TerminacionGuia { get; set; }
        public double? ResultadoEntrega { get; set; }
        public string Comentarios { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
