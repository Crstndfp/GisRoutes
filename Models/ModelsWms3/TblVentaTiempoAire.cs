using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblVentaTiempoAire
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public int Idx { get; set; }
        public int? Intento { get; set; }
        public string IdUsuario { get; set; }
        public string CodSocio { get; set; }
        public int Telefono { get; set; }
        public string Sku { get; set; }
        public string Status { get; set; }
        public string TransacSocio { get; set; }
        public string CodMensaje { get; set; }
        public string Mensaje { get; set; }
    }
}
