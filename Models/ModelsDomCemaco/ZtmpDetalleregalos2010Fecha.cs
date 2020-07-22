using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ZtmpDetalleregalos2010Fecha
    {
        public string IdEvento { get; set; }
        public string NombreEvento { get; set; }
        public DateTime? Fechaevento { get; set; }
        public string Sku { get; set; }
        public string Descripcion { get; set; }
        public int Solicitado { get; set; }
        public decimal Precio { get; set; }
        public string Area { get; set; }
    }
}
