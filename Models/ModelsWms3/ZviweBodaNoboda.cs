using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZviweBodaNoboda
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
        public int CodTipoB { get; set; }
        public string NumDocumentoB { get; set; }
        public int Linea { get; set; }
        public string Sku { get; set; }
        public string Skufact { get; set; }
        public decimal? PrecioBase { get; set; }
        public decimal Precio { get; set; }
        public decimal? PrecioOrig { get; set; }
        public int Cantidad { get; set; }
        public int DespachableBase { get; set; }
        public int Despachable { get; set; }
        public int Listo { get; set; }
        public int? Auditado { get; set; }
        public string Tipo { get; set; }
        public string AccionIncompleto { get; set; }
        public int? LineaReemplazada { get; set; }
        public string Skureemplazado { get; set; }
        public int? CodTipoC { get; set; }
        public string NumDocumentoC { get; set; }
        public int? LineaC { get; set; }
        public string IdEvento { get; set; }
        public string CodEnvoltorio { get; set; }
        public string De { get; set; }
        public string Para { get; set; }
        public string Mensaje { get; set; }
        public string IdUbicEnvuelto { get; set; }
        public string Intercambio { get; set; }
        public string NumLlamadaNc { get; set; }
    }
}
