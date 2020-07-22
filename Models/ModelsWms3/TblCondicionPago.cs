using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblCondicionPago
    {
        public int CodCondicion { get; set; }
        public string Nombre { get; set; }
        public int Dias { get; set; }
        public int DiasGracia { get; set; }
        public string Tipo { get; set; }
        public int? Tolerancia { get; set; }
        public int? Pagos { get; set; }
    }
}
