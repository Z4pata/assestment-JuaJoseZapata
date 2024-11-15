using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.Models;

namespace assestment_JuaJoseZapata.Repositories
{
    public interface IPatientRepository
    {
        Task<Patient?> Create(User user);
    }
}