using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models.ModelsDomCemaco;
using Assets.Dto;

namespace Repository.DomCemaco
{
    public class DepartmentRepository
    {
        private readonly DomCemacoContext _context;
        public DepartmentRepository(DomCemacoContext context)
        {
            _context = context;
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
                            select municipio.Nombre + " " + departamento.Nombre;

                return await query.FirstAsync();
            }
            catch (Exception)
            {
                return "";
            }

        }
        public async Task<AddressDto> GetDepAndMun(
            string codDepAndMun,
            string street,
            string zone)
        {
            string[] d = codDepAndMun.Split('-');
            try
            {
                var query = from departamento in _context.TblDepartamento
                            join municipio in _context.TblMunicipio
                                on departamento.CodDepartamento equals municipio.CodDepartamento
                            where departamento.CodDepartamento == Byte.Parse(d[0])
                                && municipio.CodMunicipio == Byte.Parse(d[1])
                            select new AddressDto
                            {
                                street = street,
                                Zone = zone,
                                township = municipio.Nombre,
                                department = departamento.Nombre
                            };

                return await query.FirstAsync();
            }
            catch (Exception)
            {
                return new AddressDto
                {
                    street = street,
                    Zone = zone,
                    township = "",
                    department = ""
                };
            }

        }
    }
}
