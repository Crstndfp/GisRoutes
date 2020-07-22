using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZtblEntregaGuia
    {
        public string Empresa { get; set; }
        public int Correlativo { get; set; }
        public DateTime? Fecha { get; set; }
        public TimeSpan? Hora { get; set; }
        public string Referencia { get; set; }
        public string Unidad { get; set; }
        public string Usuario { get; set; }
        public int? Bultos { get; set; }
    }
}
