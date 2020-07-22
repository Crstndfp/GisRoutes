using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblTransaccional
    {
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string TipoTransaccional { get; set; }
        public string Destinatario { get; set; }
        public DateTime Fecha { get; set; }
        public string Status { get; set; }
    }
}
