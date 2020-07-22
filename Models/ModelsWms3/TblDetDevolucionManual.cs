using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetDevolucionManual
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public int? TipoDoc { get; set; }
        public string Serie { get; set; }
        public int? Numero { get; set; }
        public int? TipoDocDv { get; set; }
        public string SerieDv { get; set; }
        public int NumeroDv { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Iva { get; set; }
        public int? TipoDocDvorig { get; set; }
        public string SerieDvorig { get; set; }
        public int? NumeroDvorig { get; set; }
        public int? Tipo { get; set; }
        public int? CodMotivo { get; set; }
        public string Observacion { get; set; }
    }
}
