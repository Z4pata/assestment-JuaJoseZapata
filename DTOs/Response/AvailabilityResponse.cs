using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.Models;

namespace assestment_JuaJoseZapata.DTOs.Response
{
    public class AvailabilityResponse
    {
        public int Id;
        public string? WeekDay;
        public TimeOnly StartTime;
        public TimeOnly EndTime;
        public string? DoctorName;
        public string? DoctorEmail;

    }
}