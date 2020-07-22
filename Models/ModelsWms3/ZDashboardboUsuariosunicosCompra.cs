using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZDashboardboUsuariosunicosCompra
    {
        public string Periodo { get; set; }
        public int? Clientes { get; set; }
        public int? Transacciones { get; set; }
        public int? ClientesBodas { get; set; }
        public int? TransaccionesBodas { get; set; }
        public int? ClientesNoBodas { get; set; }
        public int? TransaccionesNoBodas { get; set; }
    }
}
