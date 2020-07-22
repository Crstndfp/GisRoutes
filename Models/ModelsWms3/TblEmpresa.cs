using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblEmpresa
    {
        public string CodEmpresa { get; set; }
        public string Nombre { get; set; }
        public string Servidor { get; set; }
        public string Db { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string UsrSap { get; set; }
        public string PwdSap { get; set; }
        public string Nit { get; set; }
        public string SerieFact { get; set; }
        public string PrefijoFact { get; set; }
        public string Direccion { get; set; }
        public string CodDestGuia { get; set; }
        public string Telefono { get; set; }
        public string CodCredGuia { get; set; }
        public string CodAutoconsumo { get; set; }
        public string CodCredGuiaDet { get; set; }
    }
}
