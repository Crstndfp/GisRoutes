using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetOservicioDesc
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public int Idx { get; set; }
        public int IdxD { get; set; }
        public string Tipo { get; set; }
        public string CodTipoD { get; set; }
        public string Descuento { get; set; }
        public double? Porcentaje { get; set; }
        public decimal? Valor { get; set; }
        public int? IdxP { get; set; }
    }
}
