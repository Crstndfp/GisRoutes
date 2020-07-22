using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblCodigoPostal
    {
        public string CodigoPostal { get; set; }
        public string CodPais { get; set; }
        public int CodDepartamento { get; set; }
        public int CodMunicipio { get; set; }
        public string Zona { get; set; }
    }
}
