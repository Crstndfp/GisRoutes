using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblCreditoEcom
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int Modo { get; set; }
        public decimal Valor { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? FechaEcom { get; set; }
        public string IdUsuarioEcom { get; set; }
        public string DocEcom { get; set; }
        public DateTime? FechaTregalo { get; set; }
    }
}
