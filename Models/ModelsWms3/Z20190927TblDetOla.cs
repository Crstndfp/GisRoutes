using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class Z20190927TblDetOla
    {
        public string NumOla { get; set; }
        public int Idx { get; set; }
        public int? CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int? LineaDoc { get; set; }
        public string Sku { get; set; }
        public string Skufact { get; set; }
        public int Cantidad { get; set; }
        public string CodMedida { get; set; }
        public int Unidades { get; set; }
        public string IdUbicSug { get; set; }
        public int? CantidadRec { get; set; }
        public string CodMedidaRec { get; set; }
        public int? UnidadesRec { get; set; }
        public string IdUbicReal { get; set; }
        public string IdRecolector { get; set; }
        public DateTime? FechaRec { get; set; }
        public string IdUbicAudit { get; set; }
        public int? CodTipoDocUbic { get; set; }
        public string NumDocUbic { get; set; }
        public string EntregaSap { get; set; }
        public int? LineaEntregaSap { get; set; }
        public string TransporteSap { get; set; }
        public int? LineaTransporteSap { get; set; }
        public DateTime? FechaTransporteSap { get; set; }
        public int? EnPedido { get; set; }
        public int? Procesado { get; set; }
        public string Status { get; set; }
        public int? Intento { get; set; }
        public int? IdxOrg { get; set; }
        public int? IdxBase { get; set; }
        public string Tarima { get; set; }
        public string IdAuditor { get; set; }
        public DateTime? FechaConfSap { get; set; }
        public DateTime? FechaTarimaSap { get; set; }
        public string MsgError { get; set; }
        public int? CantidadReg { get; set; }
        public int? CantidadDeposit { get; set; }
        public int? CantidadRegDeposit { get; set; }
        public string TransporteSap2 { get; set; }
        public int? LineaTransporteSap2 { get; set; }
        public DateTime? FechaTransporteSap2 { get; set; }
    }
}
