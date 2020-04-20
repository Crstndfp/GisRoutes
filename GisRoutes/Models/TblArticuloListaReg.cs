using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class TblArticuloListaReg
    {
        public string Sku { get; set; }
        public string Skures { get; set; }
        public string Nombre { get; set; }
        public string Barras { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string UnidMed { get; set; }
        public string CodGrupo { get; set; }
        public string NomGrupo { get; set; }
        public decimal Precio { get; set; }
        public decimal? Oferta { get; set; }
    }
}
