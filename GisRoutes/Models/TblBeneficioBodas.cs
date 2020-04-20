using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblBeneficioBodas
    {
        public string CodBeneficio { get; set; }
        public string Tipo { get; set; }
        public string CodAsociado { get; set; }
        public DateTime Del { get; set; }
        public DateTime Al { get; set; }
        public string Nombre { get; set; }
        public decimal Monto { get; set; }
        public int Cantidad { get; set; }
        public int Disponbile { get; set; }
    }
}
