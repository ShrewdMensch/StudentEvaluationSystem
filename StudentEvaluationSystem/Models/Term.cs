using System.ComponentModel.DataAnnotations;

namespace StudentEvaluationSystem.Models
{
    public class Term
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
