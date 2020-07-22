using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZVwHorasEntrega
    {
        public int? CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public long? HorasEntrega { get; set; }
        public string AgrupaHorasEntrega { get; set; }
        public string EmpresaTransporte { get; set; }
    }
}
