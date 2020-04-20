using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblArticulo
    {
        public string Sku { get; set; }
        public string Nombre { get; set; }
        public string CodGrupo { get; set; }
        public string Foto { get; set; }
        public DateTime Creacion { get; set; }
        public string Garantia { get; set; }
        public string Mensaje { get; set; }
        public string CodProveedor { get; set; }
        public string ModoVenta { get; set; }
    }
}
