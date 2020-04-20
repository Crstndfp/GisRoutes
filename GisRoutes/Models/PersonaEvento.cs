using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class PersonaEvento
    {
        public string TipoEvento { get; set; }
        public decimal Correlativo { get; set; }
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
        public string Tarprivi { get; set; }
        public string Identificacion { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public Guid Rowguid { get; set; }
        public string Tienda { get; set; }
        public string Fax { get; set; }
        public string Localizador { get; set; }
        public string Celular { get; set; }
    }
}
