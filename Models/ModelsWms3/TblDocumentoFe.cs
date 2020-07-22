using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDocumentoFe
    {
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string Cae { get; set; }
        public string FirmaE { get; set; }
        public DateTime? FechaE { get; set; }
        public string Caeanul { get; set; }
        public string FirmaEanul { get; set; }
        public DateTime? FechaEanul { get; set; }
        public string Resolucion { get; set; }
        public string Status { get; set; }
    }
}
