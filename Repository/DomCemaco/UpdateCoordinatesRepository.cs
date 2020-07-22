using Assets.Dto;
using Assets.Utilities;
using Microsoft.EntityFrameworkCore;
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
        private const int ONE = 1;
        private const int ZERO = 0;

        private readonly DomCemacoContext _context;

        public UpdateCoordinatesRepository(DomCemacoContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TableShippingDirDto>> GetTblenvioDirToday() { 
        
            DateTime today = DateTime.Now;
            var query = from envio in _context.TblEnvio
                        join envioDir in _context.TblEnvioDir
                            on envio.IdEnvio equals envioDir.IdEnvio
                        where
                            DateTime.Compare(today.AddHours(-ONE).AddMinutes(-today.Minute), envio.Fecha) < ZERO
                            && DateTime.Compare(today.AddMinutes(-today.Minute), envio.Fecha) > ZERO
                            && envioDir.GeoRefX.Equals(ZERO) && envioDir.GeoRefY.Equals(ZERO) 
                        select envioDir;
            return MapperListDomCemaco.MapList(await query.ToListAsync());
        }
        public async Task<IEnumerable<TableEventDto>> GetTblEventosToday()
        {
            DateTime today = DateTime.Now;
            var query = from envio in _context.TblEnvio
                        join evento in _context.TblEvento
                            on envio.IdEvento equals evento.IdEvento
                        where
                            DateTime.Compare(today.AddHours(-ONE).AddMinutes(-today.Minute), envio.Fecha) < ZERO
                            && DateTime.Compare(today.AddMinutes(-today.Minute), envio.Fecha) > ZERO
                            && evento.GeoRefX.Equals(ZERO) && evento.GeoRefY.Equals(ZERO)
                        select evento;

            return MapperListDomCemaco.MapList(await query.ToListAsync());
        }
        public TableShippingDirDto UpdateTblEnvioDir(TableShippingDirDto tableShippingDirDto)
        {
            TblEnvioDir tblEnvioDir = MapperDomCemaco.Map(tableShippingDirDto);
            try
            {
                _context.TblEnvioDir.Update(tblEnvioDir);
                _context.SaveChanges();
                return MapperDomCemaco.Map(tblEnvioDir);
            }
            catch (DbUpdateException)
            {
                return null;
            }
        }
        public TableEventDto UpdateTblEvento(TableEventDto tableEventDto)
        {
            TblEvento tblEvento = MapperDomCemaco.Map(tableEventDto);
            try
            {
                _context.TblEvento.Update(tblEvento);
                _context.SaveChanges();
                return MapperDomCemaco.Map(tblEvento);
            }
            catch (DbUpdateException)
            {
                return null;
            }
        }
    }
}
