using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEvaluationSystem.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name="Teacher")]
        public int TeacherId { get; set; }

        [Display(Name = "Subject Type")]
        public int SubjectTypeId { get; set; }

        public Teacher Teacher { get; set; }

        [ForeignKey("SubjectTypeId")]
        public SubjectType SubjectType { get; set; }

    }
}
