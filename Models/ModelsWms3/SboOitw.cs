using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class SboOitw
    {
        public string CodEmpresa { get; set; }
        public string Sku { get; set; }
        public string CodWhsbo { get; set; }
        public int Existencia { get; set; }
        public DateTime Fecha { get; set; }
    }
}
