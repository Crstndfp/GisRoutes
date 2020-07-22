using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblEstadoVtex
    {
        public int CodEstado { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Status { get; set; }
        public string Modo { get; set; }
        public string TipoTransaccional { get; set; }
        public string Destinatario { get; set; }
        public string CopiaOculta { get; set; }
        public string QueryBusq { get; set; }
        public string QueryData { get; set; }
        public string QueryDet { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }
        public string MensajeDet { get; set; }
    }
}
