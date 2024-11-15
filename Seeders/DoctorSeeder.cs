using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Extensions;

namespace assestment_JuaJoseZapata.Seeders
{
    public class DoctorSeeder : ModelBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor {UserId = 1, Status = Status.available}
            );
        }
    }
}