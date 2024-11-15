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
        public required DbSet<Doctor> Doctors { get; set; }
        public required DbSet<Patient> Patients { get; set; }
        public required DbSet<DoctorAvailability> DoctorsAvailabilities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            RoleSeeder.Seed(modelBuilder);
            UserSeeder.Seed(modelBuilder);
            DoctorSeeder.Seed(modelBuilder);
            PatientSeeder.Seed(modelBuilder);




            modelBuilder.Entity<Doctor>()
            .Property(d => d.Status)
            .HasConversion(
                v => v.ToString(),
                v => (Status)Enum.Parse(typeof(Status), v)
            );

            modelBuilder.Entity<DoctorAvailability>()
            .Property(d => d.WeekDay)
            .HasConversion(
                v => v.ToString(),
                v => (WeekDays)Enum.Parse(typeof(WeekDays), v)
            );
        }
    }
}