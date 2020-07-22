using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class VwClientesRfmcemacocom
    {
        public string CodSocio { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono1 { get; set; }
        public int? Frecuencia { get; set; }
        public int? Recencia { get; set; }
        public decimal? MontoRfm { get; set; }
        public decimal? MontoTotal { get; set; }
        public int? TransaccionesRmf { get; set; }
        public int? TransaccionesTotales { get; set; }
        public string TarjetaAsociada { get; set; }
        public string TarjetaUtilizada { get; set; }
        public double? Boda { get; set; }
        public double? NoBoda { get; set; }
    }
}
