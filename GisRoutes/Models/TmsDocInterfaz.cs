using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TmsDocInterfaz
    {
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string Status { get; set; }
        public DateTime Fecha { get; set; }
    }
}
