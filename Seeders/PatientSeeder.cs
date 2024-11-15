using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.Models;
using Microsoft.EntityFrameworkCore;

namespace assestment_JuaJoseZapata.Seeders
{
    public class PatientSeeder : ModelBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(
                new Patient {UserId = 2}
            );
        }
    }
}