using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEvaluationSystem.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName => LastName + ", " + FirstName;

        [Required]
        public string Bio { get; set; }

        public string UserId { get; set; }

        [Required]
        public string Address { get; set; }

        public string Photo { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        public List<Subject> Subjects { get; set; }
    }
}
