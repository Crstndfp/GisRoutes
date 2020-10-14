using Assets.Dto;
using Models.ModelsWms3;

namespace Repository.Mappers
{
    public static class MapperWMS3
    {
        public static AuxGisRoutesDto Map(ZtblAuxiliarGisroutes ztblAuxiliarGisroutes)
        {
            return new AuxGisRoutesDto
            {
                NumDocumento = ztblAuxiliarGisroutes.NumDocumento,
                Estado = ztblAuxiliarGisroutes.Estado,
                GeoRefX = ztblAuxiliarGisroutes.GeoRefX,
                GeoRefY = ztblAuxiliarGisroutes.GeoRefY
            };
        }
        public static ZtblAuxiliarGisroutes Map(AuxGisRoutesDto auxGisRoutesDto)
        {
            return new ZtblAuxiliarGisroutes
            {
                NumDocumento = auxGisRoutesDto.NumDocumento,
                Estado = auxGisRoutesDto.Estado,
                GeoRefX = auxGisRoutesDto.GeoRefX,
                GeoRefY = auxGisRoutesDto.GeoRefY
            };
        }
        public static TransportDto Map(TblTransporte tblTransporte)
        {
            return new TransportDto
            {
                CodTransport = tblTransporte.CodTransporte,
                Name = tblTransporte.Nombre
            };
        }
    }
}
