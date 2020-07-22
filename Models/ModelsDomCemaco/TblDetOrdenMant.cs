using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblDetOrdenMant
    {
        public string NumOrden { get; set; }
        public int CodServRep { get; set; }
        public int Cantidad { get; set; }
        public int CodMedida { get; set; }
        public decimal Precio { get; set; }
    }
}
