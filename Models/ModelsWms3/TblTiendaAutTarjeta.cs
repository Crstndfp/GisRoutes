using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblTiendaAutTarjeta
    {
        public int CodAutorizador { get; set; }
        public string CodTienda { get; set; }
        public string Ipservidor { get; set; }
        public string PuertoServidor { get; set; }
        public string Afiliacion { get; set; }
        public string AfiliacionPos { get; set; }
        public string AfiliacionMan { get; set; }
        public double? Comision { get; set; }
        public double? ComisionPos { get; set; }
        public double? ComisionMan { get; set; }
        public string Modo { get; set; }
    }
}
