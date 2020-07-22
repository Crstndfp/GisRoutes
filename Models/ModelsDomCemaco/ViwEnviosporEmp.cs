using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ViwEnviosporEmp
    {
        public string CodCentroDist { get; set; }
        public int CodArea { get; set; }
        public string IdEnvio { get; set; }
        public DateTime Fecha { get; set; }
        public string IdEvento { get; set; }
        public string Titulo { get; set; }
        public string Empacable { get; set; }
        public string Comprador { get; set; }
        public string Observaciones { get; set; }
        public string NomStatus { get; set; }
        public string Sobre { get; set; }
    }
}
