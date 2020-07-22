using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class VwVentasporEvento1
    {
        public string Reserva { get; set; }
        public string IdEvento { get; set; }
        public string IdCaja { get; set; }
        public string Transaccion { get; set; }
        public string Sku { get; set; }
        public string Titulo { get; set; }
        public DateTime Fecharegistro { get; set; }
        public DateTime? Fechaevento { get; set; }
        public string Tiendainscripcion { get; set; }
        public string IdAsesora { get; set; }
        public string Nombreasesora { get; set; }
        public string TipoAsesora { get; set; }
        public int? Anioventa { get; set; }
        public int? Mesventa { get; set; }
        public int Cantidad { get; set; }
        public string Tipoventa { get; set; }
        public decimal Precionormal { get; set; }
        public string Tiendaventa { get; set; }
        public DateTime Fechabusqueda { get; set; }
    }
}
