using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblTamanoProducto
    {
        public int CodTamano { get; set; }
        public string Nombre { get; set; }
        public double PesoMin { get; set; }
        public double PesoMax { get; set; }
        public double Ccmin { get; set; }
        public double Ccmax { get; set; }
    }
}
