using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblLlamadaServ
    {
        public string CodEmpresa { get; set; }
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string CodSocio { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }
        public string Resolucion { get; set; }
        public DateTime FechaReg { get; set; }
        public string Status { get; set; }
        public string DocSap { get; set; }
        public string IdUsrCierre { get; set; }
        public DateTime? FechaCierre { get; set; }
        public int? CodTipoOrig { get; set; }
        public string NumDocOrig { get; set; }
        public int? CodTipoPed { get; set; }
        public string NumDocPed { get; set; }
        public int? CodRazon { get; set; }
        public string GuiaEnvio { get; set; }
        public string IdUsrRecepcion { get; set; }
        public int? Lineas { get; set; }
        public decimal? Total { get; set; }
        public string SerieFact { get; set; }
        public string NumeroFact { get; set; }
        public string Responsable { get; set; }
        public string Recolectar { get; set; }
    }
}
