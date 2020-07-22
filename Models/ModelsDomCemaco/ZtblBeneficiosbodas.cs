using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ZtblBeneficiosbodas
    {
        public string NumTarjeta { get; set; }
        public string IdAsociado { get; set; }
        public byte CodTipo { get; set; }
        public string Nombre { get; set; }
        public decimal? Puntos { get; set; }
    }
}
