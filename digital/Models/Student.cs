using System.ComponentModel.DataAnnotations;

namespace digital.Models
{
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }   
        public int SubCategoryId { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public string Gender { get; set; }

        [RegularExpression(@"^\d{10}$", ErrorMessage = "Enter valid 10-digit mobile number")]
        public string MobileNumber { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
    }

}