using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblGuiaEnvio
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int CodTipoG { get; set; }
        public string NumGuia { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public int Bultos { get; set; }
        public string CodOrigen { get; set; }
        public string CodDestino { get; set; }
        public string Status { get; set; }
    }
}
