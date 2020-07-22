using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblReclamo
    {
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string CodSocio { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }
        public string Resolucion { get; set; }
        public DateTime FechaReg { get; set; }
        public string FacturaAfecta { get; set; }
        public string FacturaOrigen { get; set; }
        public string Sku { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int Bultos { get; set; }
        public int Recolector { get; set; }
        public int StatusRec { get; set; }
        public string Status { get; set; }
        public string DocSap { get; set; }
        public string IdAutorizador { get; set; }
        public DateTime? FechaAut { get; set; }
    }
}
