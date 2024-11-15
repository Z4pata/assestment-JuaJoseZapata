using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.Models;
using Microsoft.EntityFrameworkCore;

namespace assestment_JuaJoseZapata.Seeders
{
    public class DoctorAvailabilitySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoctorAvailability>().HasData(
                new DoctorAvailability {Id = 1, DoctorId = 1, WeekDay = WeekDays.monday, StartTime = new TimeOnly(6, 0), EndTime = new TimeOnly(14, 0)},
                new DoctorAvailability {Id = 2, DoctorId = 1, WeekDay = WeekDays.tuesday, StartTime = new TimeOnly(6, 0), EndTime = new TimeOnly(14, 0)},
                new DoctorAvailability {Id = 3, DoctorId = 1, WeekDay = WeekDays.wednesday, StartTime = new TimeOnly(6, 0), EndTime = new TimeOnly(14, 0)},
                new DoctorAvailability {Id = 4, DoctorId = 1, WeekDay = WeekDays.thursday, StartTime = new TimeOnly(6, 0), EndTime = new TimeOnly(14, 0)},
                new DoctorAvailability {Id = 5, DoctorId = 1, WeekDay = WeekDays.friday, StartTime = new TimeOnly(10, 0), EndTime = new TimeOnly(14, 0)}
            );
        }
    }
}