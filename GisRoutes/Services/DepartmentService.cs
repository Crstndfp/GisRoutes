using GisRoutes.Dto;
using GisRoutes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GisRoutes.Services
{
    public class DepartmentService
    {
        private readonly DomCemacoContext _context;

        public DepartmentService(DomCemacoContext context)
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
        public async Task<Address> GetDepAndMun(
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
                            where departamento.CodDepartamento ==  Byte.Parse(d[0])
                                && municipio.CodMunicipio == Byte.Parse(d[1])
                            select new Address
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
                return new Address
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
