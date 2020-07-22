using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class CompExistencia
    {
        public string Sku { get; set; }
        public string IdUbicacion { get; set; }
        public string CodMedida { get; set; }
        public int Cantidad { get; set; }
        public int UnidMed { get; set; }
        public int Existencia { get; set; }
        public int Reservado { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
