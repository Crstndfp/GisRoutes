using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblListaPrecios
    {
        public short CodLista { get; set; }
        public string Nombre { get; set; }
        public decimal? Factor { get; set; }
    }
}
