using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.DTOs.Request;
using Microsoft.AspNetCore.Mvc;

namespace assestment_JuaJoseZapata.Controllers.v1.Auth
{
    public partial class AuthController
    {
        [HttpPost("register")]
        public async Task<IActionResult> Create(RegisterRequest request)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newUser = await _service.Create(request);


            return CreatedAtAction(nameof(Create), new { id = newUser?.Id }, new 
            {
                message = "User created successfully",
                User_Id = newUser?.Id
            });
        }
    }
}