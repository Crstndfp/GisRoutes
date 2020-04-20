using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ZtmpdetEnviosinenvios
    {
        public string IdEnvio { get; set; }
        public string Sku { get; set; }
        public string Color { get; set; }
        public string Descripcion { get; set; }
        public string Ambiente { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int CodTipoEmpaque { get; set; }
        public int CodTamano { get; set; }
        public string EmpaqTienda { get; set; }
        public string Status { get; set; }
        public string TiendasB { get; set; }
    }
}
