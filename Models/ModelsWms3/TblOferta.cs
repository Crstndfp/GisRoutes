﻿using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblOferta
    {
        public string Sku { get; set; }
        public string CodCliente { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Descuento { get; set; }
        public int CodLista { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public string NumPromocion { get; set; }
    }
}
