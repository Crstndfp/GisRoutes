using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblEmpaque
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int Linea { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
    }
}
