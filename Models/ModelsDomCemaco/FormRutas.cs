using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class FormRutas
    {
        public DateTime? Timestamp { get; set; }
        public string SeleccioneElTipoDeGuíaDatosAntesDelGuión { get; set; }
        public double? IngreseElNúmeroDeGuíaDespuésDelGuiónAntesDel1 { get; set; }
        public string GuíaTerminaEn1 { get; set; }
        public string ResultadoDeLaEntrega { get; set; }
        public string PersonaQueEntrega { get; set; }
        public string PersonaQueRecibe { get; set; }
        public string IngreseElNúmeroDeGuíaDespésDelGuiónAntesDel1 { get; set; }
        public string ComentariosEntrega { get; set; }
        public string FotografíasDeEntregaGuíaFirmadaYClienteRecibiendoSuPed { get; set; }
        public string NoName { get; set; }
        public string NoName1 { get; set; }
        public string NoName2 { get; set; }
        public DateTime? FechaDeVisita { get; set; }
        public DateTime? HoraDeVisita { get; set; }
    }
}
