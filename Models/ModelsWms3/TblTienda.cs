using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblTienda
    {
        public string CodEmpresa { get; set; }
        public string CodTienda { get; set; }
        public string Nombre { get; set; }
        public int? Prioridad { get; set; }
        public string DespEcom { get; set; }
        public string CodPais { get; set; }
        public string CodEstado { get; set; }
        public string CodMunicipio { get; set; }
        public string Zona { get; set; }
        public string CodCentroDist { get; set; }
        public int? CodTipo { get; set; }
        public string NombreEcom { get; set; }
        public string IdvtexPickUpPt { get; set; }
    }
}
