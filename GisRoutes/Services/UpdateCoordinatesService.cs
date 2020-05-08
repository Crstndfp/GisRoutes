using GisRoutes.Models;
using GisRoutes.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GisRoutes.Services
{
    public class UpdateCoordinatesService
    {
        private const int ONE = 1;
        private const int ZERO = 0;

        private readonly DomCemacoContext _context;
        private readonly DepartmentService departmentService;

        public UpdateCoordinatesService(
            DomCemacoContext context,
            DepartmentService departmentService)
        {
            _context = context;
            this.departmentService = departmentService;
        }
        public async Task<IEnumerable<TblEnvioDir>> UpdateCoordinatesEnvioDir() { 
        
            DateTime today = DateTime.Now;
            var query = from envio in _context.TblEnvio
                        join envioDir in _context.TblEnvioDir
                            on envio.IdEnvio equals envioDir.IdEnvio
                        where
                            DateTime.Compare(today.AddHours(-ONE).AddMinutes(-today.Minute), envio.Fecha) < ZERO
                            && DateTime.Compare(today.AddMinutes(-today.Minute), envio.Fecha) > ZERO
                            && envioDir.GeoRefX.Equals(ZERO) && envioDir.GeoRefY.Equals(ZERO) 
                        select envioDir;

            IEnumerable<TblEnvioDir> list = await query.ToListAsync();

            foreach (TblEnvioDir t in list)
            {
                AddressTools addressTools = new AddressTools(
                    t.Direccion,
                    t.Zona,
                    await departmentService.GetDepAndMun(
                    t.CodDepartamento, t.CodMunicipio));
                TblEnvioDir aux = addressTools.UpdateCoordinatesEnvioDir(t);
                t.GeoRefY = aux.GeoRefY;
                t.GeoRefX = aux.GeoRefX;
                UpdateTblEnvioDir(t);
            }
            return list;
        }

        public async Task<IEnumerable<TblEvento>> UpdateCoordinatesEnvento()
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

            IEnumerable<TblEvento> list = await query.ToListAsync();

            foreach (TblEvento t in list)
            {
                AddressTools addressTools = new AddressTools(
                    t.Direccion,
                    t.Zona,
                    await departmentService.GetDepAndMun(
                    t.CodDepartamento ?? ONE, t.CodMunicipio ?? ONE));
                TblEvento aux = addressTools.UpdateCoordinatesEvento(t);
                t.GeoRefY = aux.GeoRefY;
                t.GeoRefX = aux.GeoRefX;
                UpdateTblEvento(t);
            }
            return list;
        }

        public TblEnvioDir UpdateTblEnvioDir(TblEnvioDir tblEnvioDir)
        {
            try
            {
                _context.TblEnvioDir.Update(tblEnvioDir);
                _context.SaveChanges();
                return tblEnvioDir;
            }
            catch (DbUpdateException)
            {
                return null;
            }
            
        }

        public TblEvento UpdateTblEvento(TblEvento tblEvento)
        {
            try
            {
                _context.TblEvento.Update(tblEvento);
                _context.SaveChanges();
                return tblEvento;
            }
            catch (DbUpdateException)
            {
                return null;
            }
        }
    }
}
