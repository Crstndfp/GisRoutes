﻿using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDocumentoFeMail
    {
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string EMail { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
