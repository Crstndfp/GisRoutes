﻿using Assets.Dto;
using Assets.Utilities;
using Microsoft.Extensions.Logging;
using Models.ModelsWms3;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository.Wms3
{
    public class DepartmentRepositoryLec
    {
        private readonly WMS3Context _context;
        private readonly ILogger _logger;

        public DepartmentRepositoryLec(
          WMS3Context context,
          ILogger<DepartmentRepositoryLec> logger
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
        public AddressDto GetDepAndMun(
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

                return query.First();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, codDepAndMun, e.StackTrace);
                throw new Exception();
            }

        }

    }
}
