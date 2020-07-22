using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class VwFormularioEntrega
    {
        public string IdGuia { get; set; }
        public DateTime? Fecha { get; set; }
        public string Status1 { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
        public string Comentario { get; set; }
    }
}
