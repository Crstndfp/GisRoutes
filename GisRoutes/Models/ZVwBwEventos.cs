using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ZVwBwEventos
    {
        public string IdEvento { get; set; }
        public int TipoEvento { get; set; }
        public string Titulo { get; set; }
        public string TiendaRegistro { get; set; }
        public string IdAsesora { get; set; }
        public string TipoAsesora { get; set; }
        public string TipoLista { get; set; }
        public string FechaDeInscripción { get; set; }
        public string FechaLista { get; set; }
        public string Lista { get; set; }
        public string IdAsociado { get; set; }
    }
}
