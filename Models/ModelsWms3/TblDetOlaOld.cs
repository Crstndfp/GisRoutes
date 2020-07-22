using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetOlaOld
    {
        public string NumOla { get; set; }
        public int? Idx { get; set; }
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
        public int? EnPedido { get; set; }
        public int? Procesado { get; set; }
        public string Status { get; set; }
        public int? Intento { get; set; }
        public int? IdxOrg { get; set; }
    }
}
