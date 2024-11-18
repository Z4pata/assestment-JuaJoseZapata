using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace assestment_JuaJoseZapata.Controllers.v1.Availability
{
    public partial class AvailabilityController
    {
        [HttpGet]
        [Authorize(Policy = "DoctorPolicy")]
        public async Task<IActionResult> GetAllByDoctorId(int id)
        {
            var availabilities = await _service.GetAvailabilityByDoctorId(id);

            return Ok(availabilities);
        }
    }
}