using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ViwDetTraslado
    {
        public string IdTraslado { get; set; }
        public string IdEnvio { get; set; }
        public string Sku { get; set; }
        public string Color { get; set; }
        public int Cantidad { get; set; }
        public int Enviado { get; set; }
        public int Recibido { get; set; }
        public DateTime? FechaRecep { get; set; }
        public string Descripcion { get; set; }
    }
}
