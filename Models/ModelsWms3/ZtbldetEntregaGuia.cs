using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZtbldetEntregaGuia
    {
        public string Empresa { get; set; }
        public int Correlativo { get; set; }
        public string NoGuia { get; set; }
        public DateTime? Fecha { get; set; }
        public TimeSpan? Hora { get; set; }
    }
}
