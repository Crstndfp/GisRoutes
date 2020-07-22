using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDespiece
    {
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public string Sku { get; set; }
        public string Status { get; set; }
        public string Serie { get; set; }
        public string IdUbicacion { get; set; }
        public string NumDocPedido { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public string IdUsrCierre { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string NumDocFinal { get; set; }
    }
}
