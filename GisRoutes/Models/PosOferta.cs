using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class PosOferta
    {
        public string Codpro { get; set; }
        public decimal Valor { get; set; }
        public DateTime Fechaini { get; set; }
        public DateTime Fechafin { get; set; }
        public string Unimed { get; set; }
        public string TipoOferta { get; set; }
        public string NumeroPromocion { get; set; }
    }
}
