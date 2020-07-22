using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZVwDashboardTiendas2
    {
        public string NumeroRequerimiento { get; set; }
        public string NumeroDocumento { get; set; }
        public string NumeroPedido { get; set; }
        public string Sku { get; set; }
        public string NombreSku { get; set; }
        public string Departamento { get; set; }
        public string Categoria { get; set; }
        public string Tienda { get; set; }
        public DateTime? FechaRequerimiento { get; set; }
        public DateTime? FechaConfirma { get; set; }
        public int? AñoCalendarioConf { get; set; }
        public int? MesCalendarioConf { get; set; }
        public int? DiaCalendarioConf { get; set; }
        public int? HoraCalendarioConf { get; set; }
        public DateTime? FechaAudita { get; set; }
        public int? AñoCalendarioAudita { get; set; }
        public int? MesCalendarioAudita { get; set; }
        public int? DiaCalendarioAudita { get; set; }
        public int? HoraCalendarioAudita { get; set; }
        public DateTime? FechaRecibeCatm { get; set; }
        public int? AñoRequerimiento { get; set; }
        public int? MesRequerimiento { get; set; }
        public int? DiaRequerimiento { get; set; }
        public int? HoraRequerimiento { get; set; }
        public string NombreEstado { get; set; }
        public string UsuarioConfirma { get; set; }
        public string NombreUsuarioConfirma { get; set; }
        public string UsuarioAudita { get; set; }
        public string NombreUsuarioAudita { get; set; }
        public int Cantidad { get; set; }
        public int? CantidadConfirma { get; set; }
        public int? CantidadAudita { get; set; }
    }
}
