using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class VwRecorridoEventoAdultosReporteDinamico
    {
        public string IdEvento { get; set; }
        public string Titulo { get; set; }
        public DateTime Inscripcion { get; set; }
        public string Tipo { get; set; }
        public string IdAsesora { get; set; }
        public string NombreAsesora { get; set; }
        public string TipoAsesora { get; set; }
        public string RealizaRecorrido { get; set; }
        public DateTime? FechaRecorrido { get; set; }
        public string TiendaRecorrido { get; set; }
        public string TiendaInscripcion { get; set; }
        public DateTime? FechaEvento { get; set; }
        public string TieneRecorrido { get; set; }
        public string Tiempo { get; set; }
        public string NombreNovia { get; set; }
        public string NoviaEmail { get; set; }
        public string NoviaTelefonos { get; set; }
        public string NombreNovio { get; set; }
        public string NovioEmail { get; set; }
        public string NovioTelefonos { get; set; }
        public DateTime? FechaEvento1 { get; set; }
    }
}
