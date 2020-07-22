using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZVwPickingFechaOla
    {
        public DateTime? FechaOla { get; set; }
        public string NumOla { get; set; }
        public string TransporteSap { get; set; }
        public int? LineaTransporteSap { get; set; }
        public string Ubic { get; set; }
        public string Recolector { get; set; }
        public int Unidades { get; set; }
        public int? UnidadesRec { get; set; }
        public string Tarima { get; set; }
        public DateTime? FechaTarima { get; set; }
        public string Tienda { get; set; }
        public string Pedido { get; set; }
        public DateTime? FechaPick { get; set; }
        public int Linea { get; set; }
        public int NoPick { get; set; }
        public int Pick { get; set; }
        public int Pick0 { get; set; }
        public int PickParcial { get; set; }
        public int PickTotal { get; set; }
        public string Comentarios { get; set; }
    }
}
