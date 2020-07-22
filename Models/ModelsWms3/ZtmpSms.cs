using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZtmpSms
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string DocSap { get; set; }
        public string Incompleto { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
    }
}
