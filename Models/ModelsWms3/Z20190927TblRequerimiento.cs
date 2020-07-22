using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class Z20190927TblRequerimiento
    {
        public string NumRequerimiento { get; set; }
        public string NumTraslado { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int Linea { get; set; }
        public string Sku { get; set; }
        public string CodTienda { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public int CantidadReg { get; set; }
        public int? CantidadConf { get; set; }
        public int? CantidadAudit { get; set; }
        public string Status { get; set; }
        public string IdUsuarioConf { get; set; }
        public DateTime? FechaConf { get; set; }
        public string IdUsuarioAudit { get; set; }
        public DateTime? FechaAudit { get; set; }
        public int? CantidadRecibida { get; set; }
        public int? CantidadRegRecibida { get; set; }
        public string IdUsuarioRecep { get; set; }
        public DateTime? FechaRecep { get; set; }
        public string IdUbicRecep { get; set; }
        public int? CodTipoDocUbic { get; set; }
        public string NumDocUbic { get; set; }
        public string DocSap { get; set; }
        public string MsgError { get; set; }
    }
}
