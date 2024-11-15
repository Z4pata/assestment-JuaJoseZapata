using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.Models;
using assestment_JuaJoseZapata.Seeders;
using Microsoft.EntityFrameworkCore;

namespace assestment_JuaJoseZapata.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public required DbSet<Role> Roles { get; set; }
        public required DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            RoleSeeder.Seed(modelBuilder);
            UserSeeder.Seed(modelBuilder);
        }
    }
}