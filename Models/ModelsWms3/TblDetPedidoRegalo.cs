using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetPedidoRegalo
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int? Linea { get; set; }
        public string IdEvento { get; set; }
        public string CodEnvoltorio { get; set; }
        public string De { get; set; }
        public string Para { get; set; }
        public string Mensaje { get; set; }
        public string IdUbicEnvuelto { get; set; }
        public string Intercambio { get; set; }
        public string NumLlamadaNc { get; set; }
    }
}
