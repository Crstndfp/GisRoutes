using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ZtmpEventoBackupBabyshower
    {
        public string IdEvento { get; set; }
        public int CodTipo { get; set; }
        public string Titulo { get; set; }
        public string CodUbicacion { get; set; }
        public string IdPersonal { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaEvento { get; set; }
        public int TipoLentrega { get; set; }
        public string CodPais { get; set; }
        public byte? CodDepartamento { get; set; }
        public byte? CodMunicipio { get; set; }
        public string Zona { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CodUbicacionEnt { get; set; }
        public int TipoLentregaMo { get; set; }
        public string CodPaisMo { get; set; }
        public byte? CodDepartamentoMo { get; set; }
        public byte? CodMunicipioMo { get; set; }
        public string ZonaMo { get; set; }
        public string DireccionMo { get; set; }
        public string TelefonoMo { get; set; }
        public string CodUbicacionEntMo { get; set; }
        public string ColorMo { get; set; }
        public string CodUbicacionLista { get; set; }
        public DateTime? FechaLista { get; set; }
        public string AcreditaPuntos { get; set; }
        public string TarjetaPrivilegio { get; set; }
        public DateTime? FechaMonia { get; set; }
        public string StatusMonia { get; set; }
        public int CodTipoLista { get; set; }
        public string Status { get; set; }
        public int GeoRefX { get; set; }
        public int GeoRefY { get; set; }
        public int GeoRefXmo { get; set; }
        public int GeoRefYmo { get; set; }
        public int? CodArea { get; set; }
        public int? CodAreaMo { get; set; }
        public string DireccionPostBoda { get; set; }
        public string TelefonoPostBoda { get; set; }
        public string Pwdinternet { get; set; }
    }
}
