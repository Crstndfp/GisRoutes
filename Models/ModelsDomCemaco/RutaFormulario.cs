using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class RutaFormulario
    {
        public double? IdFormulario { get; set; }
        public string Comentario { get; set; }
        public string IdEnvio { get; set; }
        public string Status { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
