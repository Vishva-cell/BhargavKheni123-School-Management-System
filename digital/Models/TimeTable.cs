using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace digital.Models
{
    public class TimeTable
    {
        public int Id { get; set; }

        [Required]
        public required string Std { get; set; } // Now string

        [Required]
        public required string Class { get; set; } // Now string

        [Required]
        public required string Subject { get; set; }

        [Required]
        public int StartHour { get; set; }

        [Required]
        public int StartMinute { get; set; }

        [Required]
        public int EndHour { get; set; }

        [Required]
        public int EndMinute { get; set; }



    }

}