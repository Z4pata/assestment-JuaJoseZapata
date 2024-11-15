using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace assestment_JuaJoseZapata.Controllers.v1.Auth
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class AuthController(IUserRepository userRepository, IPatientRepository patientRepository) : ControllerBase
    {
        private readonly IUserRepository _service = userRepository;
        private readonly IPatientRepository _patientService = patientRepository;
    }
}