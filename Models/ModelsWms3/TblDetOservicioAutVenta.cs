﻿using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetOservicioAutVenta
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public int Idx { get; set; }
        public int IdxD { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public int? IdxOrgImp { get; set; }
    }
}
