using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblPedido
    {
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string CodSocio { get; set; }
        public DateTime? Emision { get; set; }
        public DateTime Fecha { get; set; }
        public int? Lineas { get; set; }
        public decimal? Total { get; set; }
        public string Status { get; set; }
        public DateTime? FechaReg { get; set; }
        public string DocSap { get; set; }
        public int? CodTipoRuta { get; set; }
        public string NumOla { get; set; }
        public string Factura { get; set; }
        public DateTime? IniAuditoria { get; set; }
        public DateTime? FinAuditoria { get; set; }
        public DateTime? FechaFact { get; set; }
        public string Comentarios { get; set; }
        public int? CodTipoCred { get; set; }
        public string NumDocumentoHh { get; set; }
        public decimal? Descuento { get; set; }
        public string CodDestinatario { get; set; }
        public string CodCentroDist { get; set; }
    }
}
