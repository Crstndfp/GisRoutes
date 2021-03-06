﻿using Assets.Dto;
using Models.ModelsWms3;
using System.Collections.Generic;

namespace Repository.Mappers
{
    class MapperListWMS3
    {
        public static IEnumerable<AuxGisRoutesDto> MapList(IEnumerable<ZtblAuxiliarGisroutes> listZtblAuxiliarGisroutes)
        {
            List<AuxGisRoutesDto> list = new List<AuxGisRoutesDto>();
            foreach(ZtblAuxiliarGisroutes ztblAuxiliarGisroutes in listZtblAuxiliarGisroutes)
            {
                list.Add(MapperWMS3.Map(ztblAuxiliarGisroutes));
            }
            return list;
        }
        public static IEnumerable<TransportDto> MapList(IEnumerable<TblTransporte> listTblTransporte )
        {
            List<TransportDto> list = new List<TransportDto>();
            foreach (TblTransporte tblTransporte in listTblTransporte)
            {
                list.Add(MapperWMS3.Map(tblTransporte));
            }
            return list;
        }
    }
}
