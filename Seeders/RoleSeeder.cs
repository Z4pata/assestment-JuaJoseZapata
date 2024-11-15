using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.Models;
using Microsoft.EntityFrameworkCore;

namespace assestment_JuaJoseZapata.Seeders
{
    public class RoleSeeder : ModelBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role {Id = 1, Name = "doctor", CreationDate = DateTime.Now, UpdateDate = null},
                new Role {Id = 2, Name = "patient", CreationDate = DateTime.Now, UpdateDate = null}

            );
        }
    }
}