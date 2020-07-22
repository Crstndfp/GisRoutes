using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblTipoTarRegalo
    {
        public int CodTipo { get; set; }
        public string Nombre { get; set; }
        public string MontoFijo { get; set; }
        public decimal? ValorTarjeta { get; set; }
        public string Idtarjeta { get; set; }
        public string Sku { get; set; }
        public byte[] Imagen { get; set; }
        public string CanjeParcial { get; set; }
        public string Status { get; set; }
    }
}
