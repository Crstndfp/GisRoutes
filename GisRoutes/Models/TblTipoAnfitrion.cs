using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblTipoAnfitrion
    {
        public int CodTipo { get; set; }
        public int CodTanfitrion { get; set; }
        public string Nombre { get; set; }
        public string Obligatorio { get; set; }
        public string Duplicable { get; set; }
        public string BaseTit { get; set; }
        public string ReqDataCont { get; set; }
    }
}
