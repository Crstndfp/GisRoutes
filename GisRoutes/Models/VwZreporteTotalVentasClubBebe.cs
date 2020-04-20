using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class VwZreporteTotalVentasClubBebe
    {
        public string TiendaInscrita { get; set; }
        public int? Inscripciones { get; set; }
        public string IdEvento { get; set; }
        public string Titulo { get; set; }
        public int? Mes { get; set; }
        public int? Año { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? Tiket { get; set; }
        public string TiendaDeVenta { get; set; }
        public int? Compras { get; set; }
        public int Articulos { get; set; }
        public decimal? VentaTotal { get; set; }
    }
}
