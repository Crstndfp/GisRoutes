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
    /// <summary>
    /// Services available for shipping orders
    /// </summary>
    [Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderShippingController : ControllerBase
    {
        private readonly ShippingOrder _shippingOrder;

        public OrderShippingController(ShippingOrder shippingOrder)
        {
            _shippingOrder = shippingOrder;
        }

        /// <summary>
        /// Find delivery orders for a specific company
        /// </summary>
        /// <remarks>
        /// You can get the company code with the service /get-transports
        /// 
        /// Sample request:
        ///
        ///     GET /get-orders-for-day?date=2021/01/01ampcompany=d
        ///     
        /// </remarks>
        /// <param name="date">Format yyyy/MM/dd</param>
        /// <param name="company">code of company</param>
        /// <returns></returns>
        /// <response code="200">Return list of delivery orders</response>
        /// <response code="400">No data was found with the specified parameters</response>  
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("get-orders-for-day")]
        public async Task<ActionResult> GetOrdersShippingForDay(string date, string company)
        {
            try
            {
                return Ok(
                    await _shippingOrder.GetOrderShipping
                    (
                        DateTime.Parse(date),
                        company.Trim().ToUpper()
                    )
                    );
            }
            catch (FormatException)
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Look for delivery orders for cemaco
        /// </summary>
        /// <remarks>
        /// It will be obsolete in the following updates
        /// 
        /// Sample request:
        ///
        ///     GET /get-orders-for-day-new?date=2021/01/01
        ///     
        /// </remarks>
        /// <param name="date">Format yyyy/MM/dd</param>
        /// <response code="200">Return list of delivery orders</response>
        /// <response code="400">No data was found with the specified parameters</response>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("get-orders-for-day-new")]
        public async Task<ActionResult> GetOrdersShippingForDayNew(string date)
        {
            try
            {
                return Ok(await _shippingOrder.GetOrderShipping(DateTime.Parse(date), "D"));
            }
            catch (FormatException)
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Create a delivery status for a delivery order not yet completed
        /// </summary>
        /// <remarks>
        /// Validate information by NoRegistro, if it already exists it is not stored.
        /// 
        /// Sample request:
        ///
        ///     POST /save-delivery
        ///     {
        ///         "NoRegistro":"EC-00300621234",
        ///         "CodigoRuta":"12344",
        ///         "Fecha":"2020/05/06 14:25:45",
        ///         "IdResultado":"01",
        ///         "Persona":"Juan Matias"
        ///     }
        ///
        /// </remarks>
        /// <param name="deliveryResult"></param>
        /// <response code="201">Saved order</response>
        /// <response code="400">No data was found with the specified parameters</response>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("save-delivery")]
        public async Task<IActionResult> SaveDelivery(DeliveryResultDto deliveryResult)
        {
            if (!ModelState.IsValid)
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

        /// <summary>
        /// List of transports defined for Cemaco
        /// </summary>
        /// <remarks>
        /// Returns a transport code and a name for further searches
        /// 
        /// Sample request:
        ///
        ///     GET /get-transports
        ///     
        /// </remarks>
        /// <response code="200">Return list of delivery orders</response>
        /// <response code="400">No data was found with the specified parameters</response>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("get-transports")]
        public async Task<ActionResult> GetTransports()
        {
            try
            {
                return Ok(await _shippingOrder.GetTransport());
            }
            catch (FormatException)
            {
                return BadRequest();
            }
        }
    }
}
