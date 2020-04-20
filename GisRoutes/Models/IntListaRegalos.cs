using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class IntListaRegalos
    {
        public string IdEvento { get; set; }
        public string TipoEvento { get; set; }
        public decimal? Correlativo { get; set; }
        public string NoRegalo { get; set; }
        public string Sku { get; set; }
        public string UniMed { get; set; }
        public int? CantidadSolicitada { get; set; }
        public int? CantidadComprada { get; set; }
        public string Status { get; set; }
        public string Agregado { get; set; }
        public string Ambiente { get; set; }
        public string Modelo { get; set; }
        public string ColorDesc { get; set; }
        public string Marca { get; set; }
        public string Barra { get; set; }
        public int? Mes { get; set; }
        public int? Anio { get; set; }
        public string Descripcion { get; set; }
        public string Depto { get; set; }
        public Guid? RowGuid { get; set; }
        public string Tienda { get; set; }
        public string Vajilla { get; set; }
        public int RegaloMarcado { get; set; }
    }
}
