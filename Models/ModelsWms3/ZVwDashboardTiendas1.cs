using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZVwDashboardTiendas1
    {
        public string DocSap { get; set; }
        public decimal? TotalPedido { get; set; }
        public string Telefono { get; set; }
        public string CentroDistribucion { get; set; }
        public int? AnioCalendarioPed { get; set; }
        public int? MesCalendarioPed { get; set; }
        public int? DiaCalendarioPed { get; set; }
        public int? HoraDiaPed { get; set; }
        public DateTime FechaCalendarioPed { get; set; }
        public int? AnioCalendarioFact { get; set; }
        public int? MesCalendarioFact { get; set; }
        public int? DiaCalendarioFact { get; set; }
        public int? HoraDiaFact { get; set; }
        public DateTime? FechaCalendarioFact { get; set; }
        public string RecogerTienda { get; set; }
        public string TiendaEnQueRecoge { get; set; }
        public string Estado { get; set; }
        public int? Lineas { get; set; }
        public string Recolector { get; set; }
        public string NombreRecolector { get; set; }
    }
}
