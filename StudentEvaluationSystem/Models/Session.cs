using System.ComponentModel.DataAnnotations;

namespace StudentEvaluationSystem.Models
{
    public class Session
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Is Current?")]
        public bool IsCurrent { get; set; }
    }
}
