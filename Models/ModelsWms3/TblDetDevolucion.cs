using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetDevolucion
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public int? IdxOrg { get; set; }
        public int Idx { get; set; }
        public string Tipo { get; set; }
        public string Sku { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioBase { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioDesc { get; set; }
        public string Status { get; set; }
        public string Scanner { get; set; }
        public string TipoDv { get; set; }
        public int CodRazon { get; set; }
        public string DescRazon { get; set; }
        public int? CodEstado { get; set; }
        public string IdCajaOrig { get; set; }
        public int? TransaccionOrig { get; set; }
        public string IdEvento { get; set; }
        public string SerieOrig { get; set; }
        public string NumeroOrig { get; set; }
        public string FechaOrig { get; set; }
        public string SerieDv { get; set; }
        public string NumeroDv { get; set; }
        public string IdUsuarioAuditoria { get; set; }
        public DateTime? FechaAuditoria { get; set; }
        public string ResolucionOrig { get; set; }
        public string Uuidorig { get; set; }
        public DateTime? FfechaOrig { get; set; }
        public decimal? DescPago { get; set; }
        public decimal? PrecioFiscal { get; set; }
    }
}
