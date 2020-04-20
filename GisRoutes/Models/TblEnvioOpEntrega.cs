using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblEnvioOpEntrega
    {
        public string IdEnvio { get; set; }
        public string IngresaCamion { get; set; }
        public string EspGradas { get; set; }
        public string Garita { get; set; }
        public string CamionGar { get; set; }
        public string CodigoGar { get; set; }
        public string EntregaGar { get; set; }
        public string Edificio { get; set; }
        public string Nivel { get; set; }
        public string ElevadorCarga { get; set; }
        public string EntregaRec { get; set; }
        public string RecibeVecino { get; set; }
        public string NomVecino { get; set; }
        public string DirVecino { get; set; }
        public DateTime FechaEnt { get; set; }
        public string HorarioEnt { get; set; }
        public string EsEmpresa { get; set; }
        public string Empresa { get; set; }
        public string Recibe { get; set; }
        public string TelRecibe { get; set; }
        public string PapFactura { get; set; }
        public string PapOc { get; set; }
        public string RestEntrega { get; set; }
    }
}
