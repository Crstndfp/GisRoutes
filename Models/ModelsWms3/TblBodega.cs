using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblBodega
    {
        public string CodBodega { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string CodWhsbo { get; set; }
        public int? TipoCd { get; set; }
        public int? Prioridad { get; set; }
        public string ImpresoraFact { get; set; }
        public string ImpresoraGuia { get; set; }
        public int? PedidosAudit { get; set; }
        public double? PorcMinDespacho { get; set; }
        public int? ColchonInv { get; set; }
        public string ModoIncompletos { get; set; }
        public int? MinimoInv { get; set; }
        public string ImpresoraPicking { get; set; }
        public string IdvtexWs { get; set; }
        public string IdvtexDock { get; set; }
    }
}
