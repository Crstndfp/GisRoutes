using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ViwRegaloComprado
    {
        public string TipoEvento { get; set; }
        public decimal? Correlativo { get; set; }
        public int? Mes { get; set; }
        public int? Anio { get; set; }
        public string NumeroRegalo { get; set; }
        public string NombreComprador { get; set; }
        public string TelefonoComprador { get; set; }
        public decimal PrecioCompra { get; set; }
        public DateTime FechaCompra { get; set; }
        public string ProcesoActual { get; set; }
        public string Responsable { get; set; }
        public int NoTracking { get; set; }
        public int? Cantidad { get; set; }
        public string Tienda { get; set; }
        public string Caja { get; set; }
        public int? Notx { get; set; }
        public int NoRegLta { get; set; }
        public string Sku { get; set; }
        public string Unimed { get; set; }
        public string Enviado { get; set; }
        public Guid? Rowguid { get; set; }
        public string TiendaEvento { get; set; }
        public string Email { get; set; }
        public string TipoPrecio { get; set; }
        public int? RegaloComprado { get; set; }
    }
}
