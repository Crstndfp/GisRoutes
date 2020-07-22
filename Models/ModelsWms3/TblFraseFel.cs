using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblFraseFel
    {
        public string CodTienda { get; set; }
        public string CodMoneda { get; set; }
        public int TipoFrase { get; set; }
        public string NomFrase { get; set; }
        public int Escenario { get; set; }
        public string NomEscenario { get; set; }
    }
}
