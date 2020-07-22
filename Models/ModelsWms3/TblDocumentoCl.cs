using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDocumentoCl
    {
        public string CodTienda { get; set; }
        public int CodTipo { get; set; }
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
        public string Resolucion { get; set; }
        public string Idtributario { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Total { get; set; }
        public decimal Saldo { get; set; }
        public int Articulos { get; set; }
        public decimal Ahorro { get; set; }
        public string IdUsuario { get; set; }
        public string NumOperacion { get; set; }
        public int CodTipoTarjeta { get; set; }
        public string IdAsociado { get; set; }
        public string Tarjeta { get; set; }
        public int? Puntos { get; set; }
        public string Status { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Vendedor { get; set; }
        public string Operador { get; set; }
        public decimal? TotalFiscal { get; set; }
    }
}
