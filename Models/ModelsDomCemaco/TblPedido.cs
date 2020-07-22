using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblPedido
    {
        public string IdPedido { get; set; }
        public int CodTipo { get; set; }
        public string CodUbicacion { get; set; }
        public string IdPersonal { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string CodCliente { get; set; }
        public string CodPais { get; set; }
        public byte CodDepartamento { get; set; }
        public byte CodMunicipio { get; set; }
        public string Zona { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string TarjetaPrivilegio { get; set; }
        public string Status { get; set; }
        public int GeoRefX { get; set; }
        public int GeoRefY { get; set; }
        public string IdEnvio { get; set; }
    }
}
