using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TempDetOrdenMant
    {
        public int NumConex { get; set; }
        public int CodServRep { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int CodMedida { get; set; }
        public string NomMedida { get; set; }
        public decimal Precio { get; set; }
    }
}
