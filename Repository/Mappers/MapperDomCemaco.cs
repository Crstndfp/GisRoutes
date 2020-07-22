using Assets.Dto;
using Models.ModelsDomCemaco;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Repository.Mappers
{
    public static class MapperDomCemaco
    {
        public static TableEventDto Map(TblEvento tblEvento)
        {
            return new TableEventDto
            {
                IdEvento = tblEvento.IdEvento,
                CodTipo = tblEvento.CodTipo,
                Titulo = tblEvento.Titulo,
                CodUbicacion = tblEvento.CodUbicacion,
                IdPersonal = tblEvento.IdPersonal,
                FechaRegistro = tblEvento.FechaRegistro,
                FechaEvento = tblEvento.FechaEvento,
                TipoLentrega = tblEvento.TipoLentrega,
                CodPais = tblEvento.CodPais,
                CodDepartamento = tblEvento.CodDepartamento,
                CodMunicipio = tblEvento.CodMunicipio,
                Zona = tblEvento.Zona,
                Direccion = tblEvento.Direccion,
                Telefono = tblEvento.Telefono,
                CodUbicacionEnt = tblEvento.CodUbicacionEnt,
                TipoLentregaMo = tblEvento.TipoLentregaMo,
                CodPaisMo = tblEvento.CodPaisMo,
                CodDepartamentoMo = tblEvento.CodDepartamentoMo,
                CodMunicipioMo = tblEvento.CodMunicipioMo,
                ZonaMo = tblEvento.ZonaMo,
                DireccionMo = tblEvento.DireccionMo,
                TelefonoMo = tblEvento.TelefonoMo,
                CodUbicacionEntMo = tblEvento.CodUbicacionEntMo,
                ColorMo = tblEvento.ColorMo,
                CodUbicacionLista = tblEvento.CodUbicacionLista,
                FechaLista = tblEvento.FechaLista,
                AcreditaPuntos = tblEvento.AcreditaPuntos,
                TarjetaPrivilegio = tblEvento.TarjetaPrivilegio,
                FechaMonia = tblEvento.FechaMonia,
                StatusMonia = tblEvento.StatusMonia,
                CodTipoLista = tblEvento.CodTipoLista,
                Status = tblEvento.Status,
                GeoRefX = tblEvento.GeoRefX,
                GeoRefY = tblEvento.GeoRefY,
                GeoRefXmo = tblEvento.GeoRefXmo,
                GeoRefYmo = tblEvento.GeoRefYmo,
                CodArea = tblEvento.CodArea,
                CodAreaMo = tblEvento.CodAreaMo,
                DireccionPostBoda = tblEvento.DireccionPostBoda,
                TelefonoPostBoda = tblEvento.TelefonoPostBoda,
                Pwdinternet = tblEvento.Pwdinternet,
                CodTiendaLiq = tblEvento.CodTiendaLiq,
                Referencias = tblEvento.Referencias,
                Ecologico = tblEvento.Ecologico,
                FechaLiq = tblEvento.FechaLiq,
                IdPersonalRec = tblEvento.IdPersonalRec,
                IdPersonalLiq = tblEvento.IdPersonalLiq
            };
        }
        public static TblEvento Map(TableEventDto tableEventDto)
        {
            return new TblEvento
            {
                IdEvento = tableEventDto.IdEvento,
                CodTipo = tableEventDto.CodTipo,
                Titulo = tableEventDto.Titulo,
                CodUbicacion = tableEventDto.CodUbicacion,
                IdPersonal = tableEventDto.IdPersonal,
                FechaRegistro = tableEventDto.FechaRegistro,
                FechaEvento = tableEventDto.FechaEvento,
                TipoLentrega = tableEventDto.TipoLentrega,
                CodPais = tableEventDto.CodPais,
                CodDepartamento = tableEventDto.CodDepartamento,
                CodMunicipio = tableEventDto.CodMunicipio,
                Zona = tableEventDto.Zona,
                Direccion = tableEventDto.Direccion,
                Telefono = tableEventDto.Telefono,
                CodUbicacionEnt = tableEventDto.CodUbicacionEnt,
                TipoLentregaMo = tableEventDto.TipoLentregaMo,
                CodPaisMo = tableEventDto.CodPaisMo,
                CodDepartamentoMo = tableEventDto.CodDepartamentoMo,
                CodMunicipioMo = tableEventDto.CodMunicipioMo,
                ZonaMo = tableEventDto.ZonaMo,
                DireccionMo = tableEventDto.DireccionMo,
                TelefonoMo = tableEventDto.TelefonoMo,
                CodUbicacionEntMo = tableEventDto.CodUbicacionEntMo,
                ColorMo = tableEventDto.ColorMo,
                CodUbicacionLista = tableEventDto.CodUbicacionLista,
                FechaLista = tableEventDto.FechaLista,
                AcreditaPuntos = tableEventDto.AcreditaPuntos,
                TarjetaPrivilegio = tableEventDto.TarjetaPrivilegio,
                FechaMonia = tableEventDto.FechaMonia,
                StatusMonia = tableEventDto.StatusMonia,
                CodTipoLista = tableEventDto.CodTipoLista,
                Status = tableEventDto.Status,
                GeoRefX = tableEventDto.GeoRefX,
                GeoRefY = tableEventDto.GeoRefY,
                GeoRefXmo = tableEventDto.GeoRefXmo,
                GeoRefYmo = tableEventDto.GeoRefYmo,
                CodArea = tableEventDto.CodArea,
                CodAreaMo = tableEventDto.CodAreaMo,
                DireccionPostBoda = tableEventDto.DireccionPostBoda,
                TelefonoPostBoda = tableEventDto.TelefonoPostBoda,
                Pwdinternet = tableEventDto.Pwdinternet,
                CodTiendaLiq = tableEventDto.CodTiendaLiq,
                Referencias = tableEventDto.Referencias,
                Ecologico = tableEventDto.Ecologico,
                FechaLiq = tableEventDto.FechaLiq,
                IdPersonalRec = tableEventDto.IdPersonalRec,
                IdPersonalLiq = tableEventDto.IdPersonalLiq
            };
        }
        public static TableShippingDirDto Map(TblEnvioDir tblEnvioDir)
        {
            return new TableShippingDirDto
            {
                IdEnvio = tblEnvioDir.IdEnvio,
                CodPais = tblEnvioDir.CodPais,
                CodDepartamento = tblEnvioDir.CodDepartamento,
                CodMunicipio = tblEnvioDir.CodMunicipio,
                Zona = tblEnvioDir.Zona,
                Direccion = tblEnvioDir.Direccion,
                Telefono = tblEnvioDir.Telefono,
                GeoRefX = tblEnvioDir.GeoRefX,
                GeoRefY = tblEnvioDir.GeoRefY,
                CodUbicacion = tblEnvioDir.CodUbicacion
            };
        }
        public static TblEnvioDir Map(TableShippingDirDto tableShippingDirDto)
        {
            return new TblEnvioDir
            {
                IdEnvio = tableShippingDirDto.IdEnvio,
                CodPais = tableShippingDirDto.CodPais,
                CodDepartamento = tableShippingDirDto.CodDepartamento,
                CodMunicipio = tableShippingDirDto.CodMunicipio,
                Zona = tableShippingDirDto.Zona,
                Direccion = tableShippingDirDto.Direccion,
                Telefono = tableShippingDirDto.Telefono,
                GeoRefX = tableShippingDirDto.GeoRefX,
                GeoRefY = tableShippingDirDto.GeoRefY,
                CodUbicacion = tableShippingDirDto.CodUbicacion
            };
        }
    }
}
