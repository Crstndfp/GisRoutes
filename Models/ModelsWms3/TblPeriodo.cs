using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblPeriodo
    {
        public int Anyo { get; set; }
        public int Mes { get; set; }
        public int? Trimestre { get; set; }
        public int MesesBase { get; set; }
        public int Maximos { get; set; }
        public int Minimos { get; set; }
        public double FactorAumento { get; set; }
        public decimal BaseMinima { get; set; }
        public string Status { get; set; }
        public int DiasNuevos { get; set; }
        public string NuevosBase { get; set; }
        public string NuevosCobertura { get; set; }
        public decimal CuotaEspecificos { get; set; }
        public decimal BonoVe { get; set; }
        public int RecordVe { get; set; }
        public int MaximosSup { get; set; }
        public int MinimosSup { get; set; }
    }
}
