using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class CrgUbicacion
    {
        public string IdUbicacion { get; set; }
        public string Licencia { get; set; }
        public int CodTipo { get; set; }
        public string CodBodega { get; set; }
        public string Nivel { get; set; }
        public string Pasillo { get; set; }
        public string Rack { get; set; }
        public string NivelRack { get; set; }
        public double Ancho { get; set; }
        public double Alto { get; set; }
        public double GraficoX { get; set; }
        public double GraficoY { get; set; }
        public double PesoMax { get; set; }
        public double VolumenMax { get; set; }
        public string Status { get; set; }
    }
}
