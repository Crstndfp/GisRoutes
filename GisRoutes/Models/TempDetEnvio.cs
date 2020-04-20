using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TempDetEnvio
    {
        public int NumConex { get; set; }
        public string Sku { get; set; }
        public string Color { get; set; }
        public string Descripcion { get; set; }
        public string Ambiente { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int CodTipoEmpaque { get; set; }
        public int CodTamano { get; set; }
        public string EmpaqTienda { get; set; }
        public string Etiqueta { get; set; }
        public string Origen { get; set; }
        public string ReqArmado { get; set; }
        public string EmpOriginal { get; set; }
        public string Danado { get; set; }
        public string Exhibido { get; set; }
    }
}
