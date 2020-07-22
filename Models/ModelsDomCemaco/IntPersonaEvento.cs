using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class IntPersonaEvento
    {
        public string IdEvento { get; set; }
        public string TipoEvento { get; set; }
        public decimal? Correlativo { get; set; }
        public int NoPersona { get; set; }
        public string Ape1 { get; set; }
        public string Ape2 { get; set; }
        public string Nom1 { get; set; }
        public string Nom2 { get; set; }
        public string Direccion { get; set; }
        public string Zona { get; set; }
        public string Colonia { get; set; }
        public string Telefono { get; set; }
        public string TeleOficina { get; set; }
        public string Email { get; set; }
        public string TarPrivi { get; set; }
        public string Identificacion { get; set; }
        public int? Mes { get; set; }
        public int? Anio { get; set; }
        public Guid? RowGuid { get; set; }
        public string Tienda { get; set; }
        public string Fax { get; set; }
        public string Localizador { get; set; }
        public string Celular { get; set; }
    }
}
