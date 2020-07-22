using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDocumentoFel
    {
        public string CodEmpresa { get; set; }
        public int? CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string Uuid { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
        public DateTime? FechaE { get; set; }
        public string Status { get; set; }
        public string Uuidanul { get; set; }
        public string SerieAnul { get; set; }
        public string NumeroAnul { get; set; }
        public DateTime? FechaEanul { get; set; }
        public int? IdxFel { get; set; }
    }
}
