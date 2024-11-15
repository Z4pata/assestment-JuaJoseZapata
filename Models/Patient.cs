using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace assestment_JuaJoseZapata.Models
{
    [Table("patients")]
    public class Patient
    {
        [Column("user_id")]
        [Key, ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public User? User { get; set; }
        
    }
}