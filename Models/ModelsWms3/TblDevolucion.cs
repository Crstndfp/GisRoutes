using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDevolucion
    {
        public string SerieDv { get; set; }
        public string NumeroDv { get; set; }
        public string TipoDv { get; set; }
        public decimal Total { get; set; }
        public decimal Saldo { get; set; }
        public string Status { get; set; }
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public int CodRazon { get; set; }
        public int CodEstado { get; set; }
        public string TiendaOrig { get; set; }
        public string IdCajaOrig { get; set; }
        public int? TransaccionOrig { get; set; }
        public string IdEventoOrig { get; set; }
        public string Telefono { get; set; }
        public DateTime? FechaAuditoria { get; set; }
        public decimal? TotalDescPago { get; set; }
        public decimal? TotalPrecioFiscal { get; set; }
    }
}
