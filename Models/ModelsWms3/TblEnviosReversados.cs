using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblEnviosReversados
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string IdEnvio { get; set; }
        public DateTime Fecha { get; set; }
    }
}
