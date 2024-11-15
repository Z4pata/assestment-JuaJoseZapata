using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace assestment_JuaJoseZapata.Models
{
    [Table("doctors_availabilities")]
    public class DoctorAvailability
    {
        [Key]
        public int Id { get; set; }

        [Column("doctor_id")]
        [ForeignKey(nameof(Doctor))]
        public int DoctorId { get; set; }

        [Column("weekday")]
        public WeekDays WeekDay { get; set; }

        [Column("start_time")]
        public TimeOnly StartTime { get; set; }
        
        [Column("end_time")]
        public TimeOnly EndTime { get; set; }

        public Doctor? Doctor { get; set; }

    }
    public enum WeekDays
    {
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday
    }
}