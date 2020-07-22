using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetPedidoDirAct
    {
        public DateTime FechaCambio { get; set; }
        public string IdUsuarioCambio { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string Tipo { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string CodPais { get; set; }
        public string CodEstado { get; set; }
        public string CodMunicipio { get; set; }
        public string CodPostal { get; set; }
        public string Telefono { get; set; }
        public string Nombre { get; set; }
        public string Compania { get; set; }
        public string Nit { get; set; }
        public string Email { get; set; }
        public string EnviarFe { get; set; }
        public string Zona { get; set; }
        public string Transporte { get; set; }
        public string CodTienda { get; set; }
    }
}
