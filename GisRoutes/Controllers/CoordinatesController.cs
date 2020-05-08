using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GisRoutes.Models;
using GisRoutes.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GisRoutes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoordinatesController : ControllerBase
    {
        private readonly UpdateCoordinatesService _updateCoordinatesService;
        public CoordinatesController(UpdateCoordinatesService updateCoordinatesService)
        {
            _updateCoordinatesService = updateCoordinatesService;
        }

        [HttpGet]
        [Route("get-shipping-without-coordinates")]
        public async Task<IActionResult> GetEnvioDirWithoutCoordinates()
        {
            return Ok(await _updateCoordinatesService.UpdateCoordinatesEnvioDir());
        }

        [HttpGet]
        [Route("get-event-without-coordinates")]
        public async Task<IActionResult> GetEventoDirWithoutCoordinates()
        {
            return Ok(await _updateCoordinatesService.UpdateCoordinatesEnvento());
        }

        [HttpPost]
        [Route("update-shipping")]
        public IActionResult UpdateEnvioDir(TblEnvioDir tblEnvioDir)
        {
            TblEnvioDir enDir = _updateCoordinatesService.UpdateTblEnvioDir(tblEnvioDir);
            if (enDir == null)
            {
                return BadRequest("EnvioDir not found");
            }
            return Ok(enDir);
        }

        [HttpPost]
        [Route("update-event")]
        public IActionResult UpdateEvento(TblEvento tblEvento)
        {
            TblEvento en = _updateCoordinatesService.UpdateTblEvento(tblEvento);
            if (en == null)
            {
                return BadRequest("Evento not found");
            }
            return Ok(en);
        }
    }
}