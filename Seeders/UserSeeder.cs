using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.Models;
using Microsoft.EntityFrameworkCore;

namespace assestment_JuaJoseZapata.Seeders
{
    public class UserSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User {Id = 1, Name = "Juan Jose", Email = "zapata.devs@gmail.com", Password = BCrypt.Net.BCrypt.HashPassword("password"), RoleId = 1, CreationDate = DateTime.Now},
                new User {Id = 2, Name = "Test", Email = "user@example.com", Password = BCrypt.Net.BCrypt.HashPassword("string"), RoleId = 2, CreationDate = DateTime.Now},
                new User {Id = 3, Name = "el admin", Email = "admin@example.com", Password = BCrypt.Net.BCrypt.HashPassword("string"), RoleId = 3, CreationDate = DateTime.Now}
            );
        }
    }
}