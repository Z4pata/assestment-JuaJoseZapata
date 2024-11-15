using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.Models;
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
    }
}