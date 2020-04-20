using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ViwAnalisisLiquidacionesBodasBorrar
    {
        public string IdEvento { get; set; }
        public string NombreEvento { get; set; }
        public DateTime? FechaEvento { get; set; }
        public DateTime? FechaLiquidacion { get; set; }
        public string TiendaEvento { get; set; }
        public string TiendaLiquidacion { get; set; }
        public int? CantidadEnvios { get; set; }
        public decimal? MontoEnvios { get; set; }
        public decimal? DiasParaLiquidar { get; set; }
        public string TarjetaLiquidacion { get; set; }
        public decimal MontoTarjetaLiquidacion { get; set; }
    }
}
