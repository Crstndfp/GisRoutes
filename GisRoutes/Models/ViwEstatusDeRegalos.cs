using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ViwEstatusDeRegalos
    {
        public string IdEvento { get; set; }
        public DateTime? Fechaevento { get; set; }
        public string NombreEvento { get; set; }
        public string IdEnvio { get; set; }
        public string Sku { get; set; }
        public string Descripcion { get; set; }
        public string Comprador { get; set; }
        public string Estatus { get; set; }
    }
}
