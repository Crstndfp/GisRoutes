using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblCliente
    {
        public string CodCliente { get; set; }
        public string Nombre { get; set; }
        public string CodPais { get; set; }
        public byte CodDepartamento { get; set; }
        public byte CodMunicipio { get; set; }
        public string Zona { get; set; }
        public string Direccion { get; set; }
        public string Telefonos { get; set; }
        public int GeoRefX { get; set; }
        public int GeoRefY { get; set; }
    }
}
