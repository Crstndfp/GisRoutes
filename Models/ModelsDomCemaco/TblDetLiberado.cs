using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblDetLiberado
    {
        public string IdEnvio { get; set; }
        public string Sku { get; set; }
        public string Color { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string Status { get; set; }
        public string IdUsuario { get; set; }
        public DateTime? FechaGondola { get; set; }
    }
}
