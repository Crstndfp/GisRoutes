using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ZtblEnvio
    {
        public string IdEnvio { get; set; }
        public string CodUbicacion { get; set; }
        public string IdPersonal { get; set; }
        public string IdEvento { get; set; }
        public DateTime Fecha { get; set; }
        public string Comprador { get; set; }
        public string Caja { get; set; }
        public string Transaccion { get; set; }
        public string Status { get; set; }
        public string MailEntrega { get; set; }
        public string TelEntrega { get; set; }
        public string Observaciones { get; set; }
        public int? CodTipoPago { get; set; }
        public int? CodArea { get; set; }
        public string Sobre { get; set; }
        public int? Paquetes { get; set; }
        public int? Tipo { get; set; }
        public string PorInternet { get; set; }
    }
}
