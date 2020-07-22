﻿using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ViwDetFactura
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string Skufact { get; set; }
        public int? Cantidad { get; set; }
        public decimal? PrecioBase { get; set; }
        public decimal? Precio { get; set; }
        public decimal? PrecioOrig { get; set; }
        public decimal? PrecioDesc { get; set; }
        public decimal? PrecioFiscal { get; set; }
        public int? CodTipoFinal { get; set; }
        public string NumDocFinal { get; set; }
        public int Linea { get; set; }
        public string Tipo { get; set; }
        public string Tarima { get; set; }
        public string Intercambio { get; set; }
        public string IdEvento { get; set; }
    }
}
