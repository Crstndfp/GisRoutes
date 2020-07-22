using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ZviwRegaloDetalle
    {
        public string IdEvento { get; set; }
        public string NombreEvento { get; set; }
        public DateTime FechaDeInscripción { get; set; }
        public DateTime? FechaEvento { get; set; }
        public string TiendaDeInscripción { get; set; }
        public string IdAsesora { get; set; }
        public string NombreAsesora { get; set; }
        public string TipoAsesora { get; set; }
        public int? AñoVenta { get; set; }
        public int? MesVenta { get; set; }
        public string TiendaVenta { get; set; }
        public decimal? MontoVenta { get; set; }
        public int? NoRegalos { get; set; }
        public string TipoVenta { get; set; }
    }
}
