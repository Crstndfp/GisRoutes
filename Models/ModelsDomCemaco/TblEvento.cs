﻿using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblEvento
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
        public double GeoRefX { get; set; }
        public double GeoRefY { get; set; }
        public double GeoRefXmo { get; set; }
        public double GeoRefYmo { get; set; }
        public int? CodArea { get; set; }
        public int? CodAreaMo { get; set; }
        public string DireccionPostBoda { get; set; }
        public string TelefonoPostBoda { get; set; }
        public string Pwdinternet { get; set; }
        public string CodTiendaLiq { get; set; }
        public string Referencias { get; set; }
        public string Ecologico { get; set; }
        public DateTime? FechaLiq { get; set; }
        public string IdPersonalRec { get; set; }
        public string IdPersonalLiq { get; set; }
    }
}
