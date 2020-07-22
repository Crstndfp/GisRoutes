using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblFormaPago
    {
        public int CodForma { get; set; }
        public string Nombre { get; set; }
        public string NomCorto { get; set; }
        public string CodSap { get; set; }
        public string Status { get; set; }
        public string AfectaTotal { get; set; }
        public double? MaxPago { get; set; }
        public string AcumulaPuntos { get; set; }
    }
}
