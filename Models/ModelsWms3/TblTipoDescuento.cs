using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblTipoDescuento
    {
        public string CodTipo { get; set; }
        public int Idx { get; set; }
        public string Nombre { get; set; }
        public string Imprimir { get; set; }
        public string Tipo { get; set; }
        public decimal MontoFijoDesc { get; set; }
        public double PorcentajeFijoDesc { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public string Modo { get; set; }
        public string Idtarjeta { get; set; }
        public string IdtarjetaHasta { get; set; }
        public string Precedencia { get; set; }
        public string DescuentosobreDescuento { get; set; }
        public string OfertasobreOferta { get; set; }
        public string CodGrupo { get; set; }
        public decimal? Monto { get; set; }
        public int? Cantidad { get; set; }
        public string TipoLista { get; set; }
        public string IncluyeLista { get; set; }
        public string IncluyeOfertas { get; set; }
        public string Franquear { get; set; }
        public decimal? MontoLimite { get; set; }
        public double? FactorPuntos { get; set; }
        public double? MaxPagoPuntos { get; set; }
        public string ModoExclusion { get; set; }
        public string ValidaReplica { get; set; }
        public string CodCliente { get; set; }
        public string CodTipoOrg { get; set; }
    }
}
