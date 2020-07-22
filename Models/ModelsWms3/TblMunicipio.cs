using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblMunicipio
    {
        public string CodPais { get; set; }
        public byte CodDepartamento { get; set; }
        public byte CodMunicipio { get; set; }
        public string Nombre { get; set; }
        public string NomCorto { get; set; }
        public string NomDestinoGuatex { get; set; }
        public string CodDestinoGuatex { get; set; }
    }
}
