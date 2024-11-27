using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.Data;
using assestment_JuaJoseZapata.DTOs.Response;
using assestment_JuaJoseZapata.Models;
using assestment_JuaJoseZapata.Repositories;
using Microsoft.EntityFrameworkCore;

namespace assestment_JuaJoseZapata.Service
{
    public class DoctorAvailabilityService(ApplicationDbContext context) : IDoctorAvailabilityRepository
    {
        private readonly ApplicationDbContext _context = context;
        public async Task<ICollection<AvailabilityResponse>?> GetAvailabilityByDoctorId(int id)
        {
            var availabilities = await _context.DoctorsAvailabilities.Include(d => d.Doctor)
                .ThenInclude(d => d.User)
                .Where(d => d.DoctorId == id)
                .Select(a => new AvailabilityResponse
                {
                    Id = a.Id,
                    WeekDay = a.WeekDay.ToString(),
                    StartTime = a.StartTime,
                    EndTime = a.EndTime,
                    DoctorName = a.Doctor.User.Name ?? "No Name",
                    DoctorEmail = a.Doctor.User.Email ?? "No Email"
                })
                .ToListAsync();

            return availabilities;
        }

    }
}