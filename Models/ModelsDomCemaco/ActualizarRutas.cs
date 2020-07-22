using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ActualizarRutas
    {
        public string Timestamp { get; set; }
        public string SeleccioneElTipoDeGuíaDatosAntesDelGuión { get; set; }
        public string Guia { get; set; }
        public string ResultadoDeLaEntrega { get; set; }
        public string PersonaQueEntrega { get; set; }
        public string PersonaQueRecibe { get; set; }
        public DateTime? FechaEntrega { get; set; }
    }
}
