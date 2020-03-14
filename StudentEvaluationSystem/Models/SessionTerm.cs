using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEvaluationSystem.Models
{
    public class SessionTerm
    {
        public int Id { get; set; }

        [Display(Name ="Term")]
        public int TermId { get; set; }

        [Display(Name ="Session")]
        public int SessionId { get; set; }

        [Display(Name ="Is Current?")]
        public bool IsCurrent { get; set; }

        [ForeignKey("TermId")]
        public Term Term { get; set; }

        [ForeignKey("SessionId")]
        public Session Session { get; set; }

    }
}
