using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assestment_JuaJoseZapata.DTOs.Request
{
    public class RegisterRequest
    {
        [MaxLength(50)]
        public required string Name { get; set; }

        [EmailAddress]
        public required string Email { get; set; }

        public required string Password { get; set; }
    }
}