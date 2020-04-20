using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class VwBodasTotalCompras
    {
        public string IdEvento { get; set; }
        public string Evento { get; set; }
        public int? Mes { get; set; }
        public int? Año { get; set; }
        public string TiendaInscripcion { get; set; }
        public int? ArtComprados { get; set; }
        public decimal? CompraTotal { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
