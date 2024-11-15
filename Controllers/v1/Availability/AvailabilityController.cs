using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace assestment_JuaJoseZapata.Controllers.v1.Availability
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class AvailabilityController(IDoctorAvailabilityRepository doctorAvailabilityRepository) : ControllerBase
    {
        private readonly IDoctorAvailabilityRepository _service = doctorAvailabilityRepository;
    }
}