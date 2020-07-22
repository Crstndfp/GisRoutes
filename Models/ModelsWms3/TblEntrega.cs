using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblEntrega
    {
        public string NumEntrega { get; set; }
        public string CodSocio { get; set; }
        public DateTime Fecha { get; set; }
        public string SerieId { get; set; }
        public string NumeroId { get; set; }
        public string Nombre { get; set; }
        public string Status { get; set; }
        public string IdUsuario { get; set; }
    }
}
