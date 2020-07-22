using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblInventario
    {
        public string NumDocumento { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaInic { get; set; }
        public DateTime? FechaFin { get; set; }
        public string IdUsuario { get; set; }
        public string Status { get; set; }
        public int? CodTipoDocSal { get; set; }
        public string NumDocSal { get; set; }
        public int? CodTipoDocIng { get; set; }
        public string NumDocIng { get; set; }
    }
}
