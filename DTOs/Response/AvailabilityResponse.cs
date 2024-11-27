using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.Models;

namespace assestment_JuaJoseZapata.DTOs.Response
{
    public class AvailabilityResponse
    {
        public int Id {get; set;}
        public string? WeekDay{get; set;}
        public TimeOnly StartTime{get; set;}
        public TimeOnly EndTime{get; set;}
        public string? DoctorName{get; set;}
        public string? DoctorEmail{get; set;}

    }
}