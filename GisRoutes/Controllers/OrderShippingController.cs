using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using GisRoutes.Dto;
using GisRoutes.Models;
using GisRoutes.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace GisRoutes.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderShippingController : ControllerBase
    {
        private readonly OrderShippingService _orderShipping;

        public OrderShippingController(OrderShippingService orderShipping)
        {
            _orderShipping = orderShipping;
        }

        [HttpGet]
        [Route("get-orders-for-today")]
        public async Task<ActionResult> GetOrdersShippingForToday()
        {
            return Ok(await _orderShipping.GetOrderShipping(DateTime.Today));
        }

        [HttpGet]
        [Route("get-orders-for-day")]
        public async Task<ActionResult> GetOrdersShippingForDay(string date)
        {
            try
            {
                return Ok(await _orderShipping.GetOrderShipping(DateTime.Parse(date)));
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
            return Ok(await _orderShipping.GetRoutes());
        }

        [HttpGet]
        [Route("get-routes-by-date")]
        public async Task<ActionResult> GetRoutesByDate(string date)
        {
            try
            {
                return Ok(
                    await _orderShipping.GetRoutesByDate(DateTime.Parse(date)
                    ));
            }
            catch (FormatException)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("save-delivery")]
        public IActionResult SaveDelivery(DeliveryResult deliveryResult)
        {
            string status = _orderShipping.SaveDelivery(deliveryResult);
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
