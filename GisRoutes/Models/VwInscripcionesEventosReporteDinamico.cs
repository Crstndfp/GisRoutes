using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class VwInscripcionesEventosReporteDinamico
    {
        public string IdEvento { get; set; }
        public string Titulo { get; set; }
        public DateTime? FechaInscripcion { get; set; }
        public string TiendaEventoInscripcion { get; set; }
        public string TiendaRecorrido { get; set; }
        public string NombreNovio { get; set; }
        public string EmailNovio { get; set; }
        public string TelefonoNovio { get; set; }
        public string NombreNovia { get; set; }
        public string EmailNovia { get; set; }
        public string TelefonoNovia { get; set; }
        public string TiendaLiquidacion { get; set; }
        public string IdAsesora { get; set; }
        public string NombreAsesora { get; set; }
        public string TipoAsesora { get; set; }
        public string TipoEvento { get; set; }
        public string TipoLista { get; set; }
        public DateTime? FechaLista { get; set; }
        public string Lista { get; set; }
        public DateTime? FechaEvento { get; set; }
    }
}
