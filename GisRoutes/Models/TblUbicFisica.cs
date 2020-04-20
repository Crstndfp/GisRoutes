using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblUbicFisica
    {
        public string CodUbicacion { get; set; }
        public int CodTipo { get; set; }
        public string Nombre { get; set; }
        public string CodPais { get; set; }
        public byte CodDepartamento { get; set; }
        public byte CodMunicipio { get; set; }
        public string Zona { get; set; }
        public string Direccion { get; set; }
        public string Telefonos { get; set; }
        public int GeoRefX { get; set; }
        public int GeoRefY { get; set; }
        public string PermRecorrido { get; set; }
        public string ServidorDb { get; set; }
        public string Db { get; set; }
        public string UsrDb { get; set; }
        public string PwdDb { get; set; }
        public string ValDesp { get; set; }
        public string PermiteEnvioBoda { get; set; }
        public string PermiteEnvioDom { get; set; }
        public string PermiteEnvioBodaReg { get; set; }
        public string PermiteEnvioCs { get; set; }
        public string MailIntercambio { get; set; }
        public double? GeoRefX2 { get; set; }
        public double? GeoRefY2 { get; set; }
    }
}
