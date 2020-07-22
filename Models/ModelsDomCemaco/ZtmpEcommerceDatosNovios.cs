using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ZtmpEcommerceDatosNovios
    {
        public string IdEvento { get; set; }
        public DateTime? Fechaevento { get; set; }
        public string Titulo { get; set; }
        public string Tarjetaprivilegio { get; set; }
        public string Nombretarjeta { get; set; }
        public string Novio { get; set; }
        public string Novia { get; set; }
        public string Procesado { get; set; }
    }
}
