using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblLogTarjetaSocio
    {
        public string IdCaja { get; set; }
        public string IdAsociado { get; set; }
        public int Transaccion { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public int Numero { get; set; }
    }
}
