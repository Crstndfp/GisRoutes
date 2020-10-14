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
        [Route("get-orders-for-day")]
        public async Task<ActionResult> GetOrdersShippingForDay(string date, string company)
        {
            try
            {
                return Ok(
                    await _shippingOrder.GetOrderShipping
                    (
                        DateTime.Parse(date),
                        company.Trim().ToLower()
                    )
                    );
            }
            catch (FormatException)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("get-orders-for-day-new")]
        public async Task<ActionResult> GetOrdersShippingForDayNew(string date)
        {
            try
            {
                return Ok(await _shippingOrder.GetOrderShipping(DateTime.Parse(date), ""));
            }
            catch (FormatException)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("save-delivery")]
        public async Task<IActionResult> SaveDelivery(DeliveryResultDto deliveryResult)
        {
            if (ModelState.IsValid)
            {
                return BadRequest("Error " + ModelState);
            }
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
