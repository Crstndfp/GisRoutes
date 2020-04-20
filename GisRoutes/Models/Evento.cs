using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class Evento
    {
        public string TipoEvento { get; set; }
        public decimal CorreEvento { get; set; }
        public string NombreEvento { get; set; }
        public string NombreNovio { get; set; }
        public string NombreNovia { get; set; }
        public DateTime? FechaEvento { get; set; }
        public DateTime? FechaLista { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string DireccionEntrega { get; set; }
        public string ZonaEntrega { get; set; }
        public string ColoniaEntrega { get; set; }
        public string TelefonoEntrega { get; set; }
        public string Tienda { get; set; }
        public string Observaciones { get; set; }
        public string Status { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public string Asesora { get; set; }
        public DateTime? FechaRecorrido { get; set; }
        public string AcreditaPuntos { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime? FechaDev { get; set; }
        public DateTime? FechaMonia { get; set; }
        public string StatusMonia { get; set; }
        public string PersonaRecMonia { get; set; }
        public string TextoLibre { get; set; }
        public string Observaciones1 { get; set; }
        public string Observaciones2 { get; set; }
        public string AsesoraRecorrido { get; set; }
        public string ComparteInfo { get; set; }
        public string AliasNovio { get; set; }
        public string AliasNovia { get; set; }
        public string ClaveNovios { get; set; }
        public string ClaveInvitados { get; set; }
    }
}
