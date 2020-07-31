using Microsoft.Extensions.Logging;
using Models.ModelsWms3;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Models.Assets;
using Assets.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using Repository.Mappers;
using Assets.Utilities;

namespace Repository.Wms3
{
    public class UpdatePreOrderRepository
    {
        private readonly WMS3Context _context;
        private readonly ILogger _logger;

        public UpdatePreOrderRepository
            (
            WMS3Context context,
            ILogger<UpdatePreOrderRepository> logger
            )
        {
            _context = context;
            _logger = logger; ;
        }
        public async Task<IEnumerable<AuxGisRoutesDto>> GetListAuxiliarGisRoutes()
        {
            try
            {
                //_context.Database.SetCommandTimeout(600);
                var query = from aux in _context.ZtblAuxiliarGisroutes
                            join pedidoDir in _context.TblDetPedidoDir
                                on aux.NumDocumento equals pedidoDir.NumDocumento
                            where aux.Estado.Equals(StateAuxiliarGisRoutes.JOINED)
                             && pedidoDir.Tipo.Equals(Const.STRE)
                             && pedidoDir.Transporte.Equals(Const.STRD)
                            select new AuxGisRoutesDto
                            {
                                NumDocumento = pedidoDir.NumDocumento,
                                Estado = aux.Estado,
                                Direccion = pedidoDir.Direccion,
                                CodDepartamento = byte.Parse( pedidoDir.CodEstado.Equals("") ? Const.GUATEMALA : pedidoDir.CodEstado),
                                CodMunicipio = byte.Parse(pedidoDir.CodMunicipio.Equals("") ? Const.GUATEMALA : pedidoDir.CodMunicipio),
                                GeoRefX = aux.GeoRefX,
                                GeoRefY = aux.GeoRefY,
                                Zona = pedidoDir.Zona
                            };
                return await query.ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e.StackTrace);
                return new List<AuxGisRoutesDto>();
            }
        }
        public void UpdateAuxiliarGisroutes(AuxGisRoutesDto auxGisRoutesDto)
        {
            ZtblAuxiliarGisroutes ztblAuxiliarGisroutes = MapperWMS3.Map(auxGisRoutesDto);
            try
            {
                ztblAuxiliarGisroutes.Estado = StateAuxiliarGisRoutes.UPDATED;
                _context.ZtblAuxiliarGisroutes.Update(ztblAuxiliarGisroutes);
                _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e.StackTrace);
            }
        }
    }
}
