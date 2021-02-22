using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models.ModelsDomCemaco;
using Assets.Dto;
using Microsoft.Extensions.Logging;
using Assets.Utilities;

namespace Repository.DomCemaco
{
    public class DepartmentRepository
    {
        private readonly DomCemacoContext _context;
        private readonly ILogger _logger;
        public DepartmentRepository(
            DomCemacoContext context,
            ILogger<DepartmentRepository> logger
            )
        {
            _context = context;
            _logger = logger;
        }
        public async Task<string> GetDepAndMun(
            byte codDepartment,
            byte codMunicipality)
        {
            try
            {
                var query = from departamento in _context.TblDepartamento
                            join municipio in _context.TblMunicipio
                                on departamento.CodDepartamento equals municipio.CodDepartamento
                            where departamento.CodDepartamento == codDepartment
                                && municipio.CodMunicipio == codMunicipality
                            select municipio.Nombre + Const.SPACE + departamento.Nombre;

                return await query.FirstAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e.StackTrace);
                return Const.EMPTY;
            }

        }
        public async Task<AddressDto> GetDepAndMun(
            string codDepAndMun,
            string street,
            string zone)
        {
            string[] d = codDepAndMun.Split(Const.GUION);
            try
            {
                var query = from departamento in _context.TblDepartamento
                            join municipio in _context.TblMunicipio
                                on departamento.CodDepartamento equals municipio.CodDepartamento
                            where departamento.CodDepartamento == Byte.Parse(d[Const.ZERO])
                                && municipio.CodMunicipio == Byte.Parse(d[Const.ONE])
                            select new AddressDto
                            {
                                street = street,
                                Zone = zone,
                                township = municipio.Nombre,
                                department = departamento.Nombre
                            };

                return await query.FirstAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, codDepAndMun, e.StackTrace);
                return new AddressDto
                {
                    street = street,
                    Zone = zone,
                    township = "GUATEMALA",
                    department = "GUATEMALA"
                };
            }

        }
    }
}
