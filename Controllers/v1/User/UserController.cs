using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace assestment_JuaJoseZapata.Controllers.v1.User
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class UserController(IUserRepository userRepository) : ControllerBase
    {
        private readonly IUserRepository _serviceUser = userRepository;
    }
}