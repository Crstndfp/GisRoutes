using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ZtmpBodasEcommerceCargadas
    {
        public decimal Correl { get; set; }
        public string IdEvento { get; set; }
        public string Email { get; set; }
        public DateTime? FechaCarga { get; set; }
    }
}
