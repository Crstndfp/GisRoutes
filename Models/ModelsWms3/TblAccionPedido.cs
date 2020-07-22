using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblAccionPedido
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int Idx { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public int CodTipoAcc { get; set; }
        public string Comentario { get; set; }
    }
}
