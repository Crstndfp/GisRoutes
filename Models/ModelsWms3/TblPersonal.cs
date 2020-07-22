using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblPersonal
    {
        public string CodEmpresa { get; set; }
        public string IdPersonal { get; set; }
        public string Nombre { get; set; }
        public string Region { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string IdSupervisor { get; set; }
        public string Status { get; set; }
    }
}
