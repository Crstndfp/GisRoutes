using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BussinesLogic.ShippingOrder;
using Assets.Dto;

namespace GisRoutes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoordinatesController : ControllerBase
    {
        private readonly UpdateCoordinates _updateCoordinates;
        public CoordinatesController(UpdateCoordinates updateCoordinates)
        {
            _updateCoordinates = updateCoordinates;
        }

        [HttpGet]
        [Route("get-shipping-without-coordinates")]
        public async Task<IActionResult> GetEnvioDirWithoutCoordinates()
        {
            return Ok(await _updateCoordinates.UpdateCoordinatesEnvioDir());
        }

        [HttpGet]
        [Route("get-event-without-coordinates")]
        public async Task<IActionResult> GetEventoDirWithoutCoordinates()
        {
            return Ok(await _updateCoordinates.UpdateCoordinatesEnvento());
        }
    }
}