using Assets.Dto;
using Models.ModelsDomCemaco;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Repository.Mappers
{
    public static class MapperListDomCemaco
    {
        public static IEnumerable<TableShippingDirDto> MapList(IEnumerable<TblEnvioDir> listTblEnvioDirs)
        {
            List<TableShippingDirDto> list = new List<TableShippingDirDto>();
            foreach (TblEnvioDir tblEnvioDir in listTblEnvioDirs)
            {
                list.Add(MapperDomCemaco.Map(tblEnvioDir));
            }
            return list;
        }
        public static IEnumerable<TableEventDto> MapList(IEnumerable<TblEvento> listTblEventos)
        {
            List<TableEventDto> list = new List<TableEventDto>();
            foreach(TblEvento tblEvento in listTblEventos)
            {
                list.Add(MapperDomCemaco.Map(tblEvento));
            }
            return list;
        }
    }
}
