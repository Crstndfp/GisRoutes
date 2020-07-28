using Assets.Dto;
using Assets.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Models.ModelsDomCemaco;
using Repository.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.DomCemaco
{
    public class UpdateCoordinatesRepository
    {

        private readonly DomCemacoContext _context;
        private readonly ILogger _logger;

        public UpdateCoordinatesRepository(
            DomCemacoContext context,
            ILogger<UpdateCoordinatesRepository> logger
            )
        {
            _context = context;
            _logger = logger;
        }
        public async Task<IEnumerable<TableShippingDirDto>> GetTblenvioDirToday() { 
        
            DateTime today = DateTime.Now;
            try
            {
                var query = from envio in _context.TblEnvio
                            join envioDir in _context.TblEnvioDir
                                on envio.IdEnvio equals envioDir.IdEnvio
                            where
                                DateTime.Compare(today.AddHours(-Const.ONE).AddMinutes(-today.Minute), envio.Fecha) < Const.ZERO
                                && DateTime.Compare(today.AddMinutes(-today.Minute), envio.Fecha) > Const.ZERO
                                && envioDir.GeoRefX.Equals(Const.ZERO) && envioDir.GeoRefY.Equals(Const.ZERO)
                            select envioDir;
                return MapperListDomCemaco.MapList(await query.ToListAsync());
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e.StackTrace);
                return new List<TableShippingDirDto>();
            }
            
        }
        public async Task<IEnumerable<TableEventDto>> GetTblEventosToday()
        {
            try
            {
                DateTime today = DateTime.Now;
                var query = from envio in _context.TblEnvio
                            join evento in _context.TblEvento
                                on envio.IdEvento equals evento.IdEvento
                            where
                                DateTime.Compare(today.AddHours(-Const.ONE).AddMinutes(-today.Minute), envio.Fecha) < Const.ZERO
                                && DateTime.Compare(today.AddMinutes(-today.Minute), envio.Fecha) > Const.ZERO
                                && evento.GeoRefX.Equals(Const.ZERO) && evento.GeoRefY.Equals(Const.ZERO)
                            select evento;
                return MapperListDomCemaco.MapList(await query.ToListAsync());
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e.StackTrace);
                return new List<TableEventDto>();
            }
            
        }
        public void UpdateTblEnvioDir(TableShippingDirDto tableShippingDirDto)
        {
            TblEnvioDir tblEnvioDir = MapperDomCemaco.Map(tableShippingDirDto);
            try
            {
                _context.TblEnvioDir.Update(tblEnvioDir);
                _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                _logger.LogError(e.Message, e.StackTrace);
            }
        }
        public void UpdateTblEvento(TableEventDto tableEventDto)
        {
            TblEvento tblEvento = MapperDomCemaco.Map(tableEventDto);
            try
            {
                _context.TblEvento.Update(tblEvento);
                _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                _logger.LogError(e.Message, e.StackTrace);
            }
        }
    }
}
