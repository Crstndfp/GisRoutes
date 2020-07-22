using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TempDetRuta
    {
        public int NumConex { get; set; }
        public string NumDocumento { get; set; }
        public int Indice { get; set; }
        public string Status { get; set; }
        public int Paquetes { get; set; }
        public int Recolectados { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string SerieId { get; set; }
        public string NumeroId { get; set; }
        public string Receptor { get; set; }
        public string Firma { get; set; }
        public DateTime? FechaConfirmacion { get; set; }
    }
}
