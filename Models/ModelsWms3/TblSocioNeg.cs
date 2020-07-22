using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblSocioNeg
    {
        public string CodEmpresa { get; set; }
        public string CodSocio { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Zip { get; set; }
        public string Postal { get; set; }
        public string Zippostal { get; set; }
        public string CiudadPostal { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Fax { get; set; }
        public string Contacto { get; set; }
        public string CodMoneda { get; set; }
        public string Email { get; set; }
        public string Sociedad { get; set; }
        public string Nit { get; set; }
        public double? Longitud { get; set; }
        public double? Latitud { get; set; }
        public double? Altura { get; set; }
        public int? ListaPrecios { get; set; }
        public string CodVendedor { get; set; }
        public int? CodTipoCred { get; set; }
        public int? DiaVisita { get; set; }
        public string HoraVisita { get; set; }
        public string CodTransporte { get; set; }
        public string CreditoTransp { get; set; }
        public string OlaAuto { get; set; }
    }
}
