using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetPagoInfo
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Direccion { get; set; }
        public string Idtributario { get; set; }
        public string AreaLabor { get; set; }
        public string Telefono { get; set; }
        public string Identificacion { get; set; }
        public decimal MontoLimite { get; set; }
        public int Plazo { get; set; }
        public string NoVale { get; set; }
    }
}
