using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblVehiculo
    {
        public string NumVehiculo { get; set; }
        public string Placa { get; set; }
        public string Poliza { get; set; }
        public int Modelo { get; set; }
        public int CodTipo { get; set; }
        public string Chasis { get; set; }
        public string Linea { get; set; }
        public string Serie { get; set; }
        public int CodMarca { get; set; }
        public int Cc { get; set; }
        public int Cilindros { get; set; }
        public float Toneladas { get; set; }
        public string Titulo { get; set; }
        public string Color { get; set; }
        public int Asientos { get; set; }
        public string Motor { get; set; }
        public float Acumulado { get; set; }
        public string Tacumulado { get; set; }
        public int CodCombustible { get; set; }
        public string Status { get; set; }
    }
}
