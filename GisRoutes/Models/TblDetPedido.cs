using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblDetPedido
    {
        public string IdPedido { get; set; }
        public string Sku { get; set; }
        public string Color { get; set; }
        public string Descripcion { get; set; }
        public string Ambiente { get; set; }
        public int Cantidad { get; set; }
        public int CodTipoEmpaque { get; set; }
        public int CodTamano { get; set; }
        public string EmpaqTienda { get; set; }
    }
}
