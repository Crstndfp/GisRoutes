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
            Task shippingTask = _updateCoordinates.UpdateCoordinatesEnvioDir();
            Task eventTask = _updateCoordinates.UpdateCoordinatesEnvento();
            Task preOrderTask = _updateCoordinates.UpdateCoordinatesPreOrden();
            List<Task> updateTask = new List<Task>
            {
                shippingTask,
                eventTask,
                preOrderTask
            };
            while (updateTask.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(updateTask);
                if (finishedTask == shippingTask)
                {
                    updateTask.Remove(shippingTask);
                }
                else if (finishedTask == eventTask)
                {
                    updateTask.Remove(eventTask);
                }
                else if (finishedTask == preOrderTask)
                {
                    updateTask.Remove(preOrderTask);
                }
            }
            return Ok();
        }
    }
}