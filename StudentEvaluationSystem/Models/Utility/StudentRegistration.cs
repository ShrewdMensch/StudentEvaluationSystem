using System;
using System.ComponentModel.DataAnnotations;

namespace StudentEvaluationSystem.Models.Utility
{
    public class StudentRegistration
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Sex { get; set; }

        [Required]
        [Display(Name = "State Of Origin")]
        public string StateOfOrigin { get; set; }

        [Required]
        public string Religion { get; set; }

        [Required]
        [Display(Name = "Name of Guardian/Parent")]
        public string NameOfGuardianOrParent { get; set; }

        [Required]
        [Display(Name = "Permanent Address")]
        public string PermanentAddress { get; set; }

        [Display(Name = "Class of Entry")]
        public int ClassOfEntryId { get; set; }

        [Display(Name = "Is Admin?")]
        public bool IsAdmin { get; set; }
    }
}
