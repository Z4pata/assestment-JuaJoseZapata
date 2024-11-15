using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.Data;
using assestment_JuaJoseZapata.Models;
using assestment_JuaJoseZapata.Repositories;

namespace assestment_JuaJoseZapata.Service
{
    public class PatientService(ApplicationDbContext context) : IPatientRepository
    {
        private readonly ApplicationDbContext _context = context;
        public async Task<Patient?> Create(User user)
        {
            var newPatient = new Patient
            {
                UserId = user.Id
            };

            try
            {
                _context.Patients.Add(newPatient);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return newPatient;
        }
    }
}