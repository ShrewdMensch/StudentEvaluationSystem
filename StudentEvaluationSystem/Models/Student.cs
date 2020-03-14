using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEvaluationSystem.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Display(Name ="Full Name")]
        public string FullName => LastName + ", " + FirstName;

        [Display(Name ="Registration Number")]
        public string RegistrationNumber => YearOfEntry + "/OFFA/" + Id;

        [DataType(DataType.Date)]
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

        [Required]
        [Display(Name = "Year of Entry")]
        public string YearOfEntry { get; set; }

        [Display(Name = "Class of Entry")]
        public int ClassOfEntryId { get; set; }

        [Display(Name = "Current Class")]
        public int CurrentClassId { get; set; }

        public string House { get; set; }

        [Display(Name = "Year of Graduation")]
        public string YearOfGraduation { get; set; }

        [Display(Name = "Reason of Withdrawal")]
        public string ReasonOfWithdrawal { get; set; }

        [Display(Name = "Position Held")]
        public string PositionHeld { get; set; }

        public string Photo { get; set; }

        public string UserId { get; set; }

        public bool? Promoted { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        [ForeignKey("ClassOfEntryId")]
        public Class ClassOfEntry { get; set; }

        [ForeignKey("CurrentClassId")]
        public Class CurrentClass { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public List<Result> Results { get; set; }

        public List<StudentClass> StudentClasses { get; set; }
    }
}
