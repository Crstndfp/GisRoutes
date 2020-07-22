using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblNivelServicio
    {
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string DocSap { get; set; }
        public string CodCliente { get; set; }
        public DateTime Emision { get; set; }
        public DateTime Fecha { get; set; }
        public int? CodGrupoM { get; set; }
        public int Lineas { get; set; }
        public decimal Pedido { get; set; }
        public int? CodTipoF { get; set; }
        public string NumDocumentoF { get; set; }
        public string DocSapf { get; set; }
        public DateTime? FechaF { get; set; }
        public int? LineasF { get; set; }
        public decimal? Facturado { get; set; }
    }
}
