using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assets.Dto;
using BussinesLogic.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace GisRoutes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        /// <summary>
        /// Get an authentication token
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /token
        ///     {
        ///          "UserName":"admin",
        ///          "Password":"1234"
        ///     }
        ///
        /// </remarks>
        /// <param name="userData"></param>
        /// <returns>string</returns>
        /// <response code="200">Return key of authentication</response>
        /// <response code="401">Credentials not found</response>  
        [HttpPost("token")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Token([FromBody] UserDataDto userData)
        {
            if (_authService.ValidateLogin(userData))
            {
                DateTime date = DateTime.Now;
                TimeSpan expireDate = TimeSpan.FromHours(1);
                string token = _authService.GenerateToke(date, userData.UserName, expireDate);
                return Ok(new
                {
                    Token = token,
                    ExpireAt = date.Add(expireDate)
                });
            }
            else
            {
                return StatusCode(401);
            }
        }
    }
}