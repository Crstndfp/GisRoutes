using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblRutaDespacho
    {
        public string NumOla { get; set; }
        public int Idx { get; set; }
        public string CodBodega { get; set; }
        public string Pasillo { get; set; }
        public string IdUsuario { get; set; }
        public string Modo { get; set; }
        public string IdUsuarioResp { get; set; }
        public string ModoResp { get; set; }
    }
}
