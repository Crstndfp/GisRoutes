using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblMovBodega
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public int CodTipoMov { get; set; }
        public int? Lineas { get; set; }
        public int? CodTipoOrg { get; set; }
        public string NumDocOrg { get; set; }
        public string IdUbicOrig { get; set; }
        public string IdUbicDest { get; set; }
        public string IdUsuario { get; set; }
        public string Status { get; set; }
        public string DocSap { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
