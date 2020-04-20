using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblReservaRegalo
    {
        public string IdReserva { get; set; }
        public string CodUbicacion { get; set; }
        public string IdPersonal { get; set; }
        public string IdEvento { get; set; }
        public DateTime Fecha { get; set; }
        public string Comprador { get; set; }
        public string Status { get; set; }
        public DateTime? FechaFin { get; set; }
        public string IdPersonalFin { get; set; }
        public string Caja { get; set; }
        public string Transaccion { get; set; }
    }
}
