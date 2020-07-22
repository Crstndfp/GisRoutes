using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZDashboardecVentasdiaCm
    {
        public string Diasemana { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal MontoPromediodia { get; set; }
        public decimal? TicketPromedio { get; set; }
        public int Transacciones { get; set; }
        public decimal TransaccionesPromediodia { get; set; }
    }
}
