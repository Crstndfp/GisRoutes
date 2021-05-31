using Assets.Dto;
using Assets.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Models.ModelsDomCemaco;
using Repository.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public IEnumerable<TableShippingDirDto> GetTblenvioDirToday()
        {
            DateTime today = DateTime.Now;
            try
            {
                var query = from envio in _context.TblEnvio
                            join envioDir in _context.TblEnvioDir
                                on envio.IdEnvio equals envioDir.IdEnvio
                            where
                                DateTime.Compare(today.AddDays(-10).Date, envio.Fecha.Date) < Const.ZERO
                                && envioDir.GeoRefX.Equals(Const.ZERO) && envioDir.GeoRefY.Equals(Const.ZERO)
                            select envioDir;
                return MapperListDomCemaco.MapList(query.ToList());
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e.StackTrace);
                return new List<TableShippingDirDto>();
            }
        }

        public IEnumerable<TableEventDto> GetTblEventosToday()
        {
            try
            {
                DateTime today = DateTime.Now;
                var query = from envio in _context.TblEnvio
                            join evento in _context.TblEvento
                                on envio.IdEvento equals evento.IdEvento
                            where
                                DateTime.Compare(today.AddDays(-10).Date, envio.Fecha.Date) < Const.ZERO
                                && evento.GeoRefX.Equals(Const.ZERO) && evento.GeoRefY.Equals(Const.ZERO)
                            select evento;
                return MapperListDomCemaco.MapList(query.ToList());
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e.StackTrace);
                return new List<TableEventDto>();
            }
        }

        public void UpdateTblEnvioDir(TableShippingDirDto tableShippingDirDto)
        {
            try
            {
                TblEnvioDir tblEnvioDir = _context.TblEnvioDir
                    .Where(ed => ed.IdEnvio == tableShippingDirDto.IdEnvio)
                    .FirstOrDefault();
                tblEnvioDir.GeoRefY = tableShippingDirDto.GeoRefY;
                tblEnvioDir.GeoRefX = tableShippingDirDto.GeoRefX;
                _context.TblEnvioDir.Update(tblEnvioDir);
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                _logger.LogError(e.Message, e.StackTrace);
            }
        }

        public void UpdateTblEvento(TableEventDto tableEventDto)
        {
            try
            {
                TblEvento tblEvento = _context.TblEvento
                    .Where(ev => ev.IdEvento == tableEventDto.IdEvento)
                    .FirstOrDefault();
                tblEvento.GeoRefX = tableEventDto.GeoRefX;
                tblEvento.GeoRefY = tableEventDto.GeoRefY;
                _context.TblEvento.Update(tblEvento);
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                _logger.LogError(e.Message, e.StackTrace);
            }
        }
    }
}