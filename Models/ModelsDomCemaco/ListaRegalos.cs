using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ListaRegalos
    {
        public string TipoEvento { get; set; }
        public decimal Correlativo { get; set; }
        public int NoRegalo { get; set; }
        public string Sku { get; set; }
        public string Unimed { get; set; }
        public int CantidadSolicitada { get; set; }
        public int CantidadComprada { get; set; }
        public string Status { get; set; }
        public string Agregado { get; set; }
        public string Ambiente { get; set; }
        public string Modelo { get; set; }
        public string Colordesc { get; set; }
        public string Marca { get; set; }
        public string Barra { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public string Descripcion { get; set; }
        public string Depto { get; set; }
        public Guid Rowguid { get; set; }
        public string Tienda { get; set; }
        public string Vajilla { get; set; }
        public int RegaloMarcado { get; set; }
    }
}
