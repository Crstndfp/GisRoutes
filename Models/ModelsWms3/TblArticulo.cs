using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblArticulo
    {
        public string CodEmpresa { get; set; }
        public string Sku { get; set; }
        public string Nombre { get; set; }
        public string CodGrupo { get; set; }
        public string Foto { get; set; }
        public DateTime Creacion { get; set; }
        public string Categoria { get; set; }
        public int? CodMarca { get; set; }
        public int? CodGrupoMarca { get; set; }
        public string Modelo { get; set; }
    }
}
