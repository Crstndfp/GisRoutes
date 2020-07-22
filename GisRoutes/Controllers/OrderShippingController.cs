using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using BussinesLogic.ShippingOrder;
using Assets.Dto;

namespace GisRoutes.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderShippingController : ControllerBase
    {
        private readonly ShippingOrder _shippingOrder;

        public OrderShippingController(ShippingOrder shippingOrder)
        {
            _shippingOrder = shippingOrder;
        }

        [HttpGet]
        [Route("get-orders-for-today")]
        public async Task<ActionResult> GetOrdersShippingForToday()
        {
            return Ok(await _shippingOrder.GetOrderShipping(DateTime.Today));
        }

        [HttpGet]
        [Route("get-orders-for-day")]
        public async Task<ActionResult> GetOrdersShippingForDay(string date)
        {
            try
            {
                return Ok(await _shippingOrder.GetOrderShipping(DateTime.Parse(date)));
            }
            catch (FormatException)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("get-routes")]
        public async Task<ActionResult> GetTblDetEnvio()
        {
            return Ok(await _shippingOrder.GetRoutes());
        }

        [HttpGet]
        [Route("get-routes-by-date")]
        public async Task<ActionResult> GetRoutesByDate(string date)
        {
            try
            {
                return Ok(
                    await _shippingOrder.GetRoutesByDate(DateTime.Parse(date)
                    ));
            }
            catch (FormatException)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("save-deliverys")]
        public async Task<IActionResult> SaveDelivery(DeliveryResultDto deliveryResult)
        {
            string status = await _shippingOrder.SaveDelivery(deliveryResult);
            if (status.Equals("Success"))
            {
                return Created(status, deliveryResult);
            }
            else if (status.Equals("NoRegister not found"))
            {
                return BadRequest("Error " + status);
            }
            else
            {
                return StatusCode(500, "Error " + status);
            }
        }
    }
}
