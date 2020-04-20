using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GisRoutes.Dto;
using GisRoutes.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost("token")]
        public IActionResult Token([FromBody] UserData userData)
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