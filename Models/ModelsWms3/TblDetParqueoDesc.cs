using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetParqueoDesc
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public string CodSocio { get; set; }
        public string Ticket { get; set; }
        public string Modo { get; set; }
        public int CodRazon { get; set; }
        public string CodDescuento { get; set; }
        public decimal? MontoTotal { get; set; }
        public decimal? MontoDesc { get; set; }
        public string IdUsuario { get; set; }
        public DateTime? Fecha { get; set; }
        public string IdUsuarioAut { get; set; }
    }
}
