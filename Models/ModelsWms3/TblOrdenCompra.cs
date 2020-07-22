using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblOrdenCompra
    {
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string CodSocio { get; set; }
        public string Embarque { get; set; }
        public DateTime Fecha { get; set; }
        public int? Lineas { get; set; }
        public decimal? Total { get; set; }
        public string Status { get; set; }
        public DateTime? FechaReg { get; set; }
        public string DocSap { get; set; }
        public string CodBodega { get; set; }
    }
}
