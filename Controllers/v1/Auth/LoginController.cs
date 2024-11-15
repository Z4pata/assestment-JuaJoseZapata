using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.Config;
using assestment_JuaJoseZapata.DTOs.Request;
using Microsoft.AspNetCore.Mvc;

namespace assestment_JuaJoseZapata.Controllers.v1.Auth
{
    public partial class AuthController
    {
         [HttpPost("login")]
        public async Task<IActionResult> Login (LoginRequest request)
        {
            var user = await _service.GetByEmail(request.Email);

            if (user == null)
            {
                return NotFound("User by that credentials Not found");
            }

            if (!_service.CheckPassword(request.Password, user))
            {
                return BadRequest("Incorrect credentials");
            }

            var token = JWT.GenerateJwtToken(user);

            return Ok($"Logeado con exito, su token es: {token}");
        }
    }
}