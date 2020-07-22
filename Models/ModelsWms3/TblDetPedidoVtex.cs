using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetPedidoVtex
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int Linea { get; set; }
        public string Carrier { get; set; }
        public string Dock { get; set; }
        public string Warehouse { get; set; }
        public string Tiempo { get; set; }
        public DateTime? Fcompromiso { get; set; }
        public string DelvChannel { get; set; }
        public string PickUpPoint { get; set; }
    }
}
