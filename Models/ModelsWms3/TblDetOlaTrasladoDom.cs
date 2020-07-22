using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetOlaTrasladoDom
    {
        public string NumOla { get; set; }
        public int Idx { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string DocSap { get; set; }
        public DateTime Fecha { get; set; }
        public string Error { get; set; }
    }
}
