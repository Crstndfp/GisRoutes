using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDocumento
    {
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int CodTipoOrig { get; set; }
        public string NumDocOrig { get; set; }
        public string CodSocio { get; set; }
        public DateTime Fecha { get; set; }
        public int Lineas { get; set; }
        public decimal? Descuento { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        public DateTime? FechaImp { get; set; }
        public string DocSap { get; set; }
        public string IdUsrImp { get; set; }
        public DateTime? FechaAnul { get; set; }
        public string DocSapanul { get; set; }
        public string IdUsrAnul { get; set; }
        public string CodDestinatario { get; set; }
    }
}
