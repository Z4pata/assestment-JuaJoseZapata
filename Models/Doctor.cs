using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace assestment_JuaJoseZapata.Models
{
    [Table("doctors")]
    public class Doctor
    {
        [Column("user_id")]
        [Key, ForeignKey(nameof(User))]
        public int UserId { get; set; }

        [Column("status")]
        [EnumDataType(typeof(Status))]
        public Status Status {get;set;}

        public User? User { get; set; }

    }

    public enum Status
    {
        available,
        unavailable

    }
}