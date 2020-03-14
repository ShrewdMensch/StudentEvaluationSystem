using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEvaluationSystem.Models
{
    public class StudentClass
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public int SessionTermId { get; set; }

        [Display(Name = "Class")]
        public int ClassId { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        [ForeignKey("ClassId")]
        public Class Class { get; set; }

        [ForeignKey("SessionTermId")]
        public SessionTerm SessionTerm { get; set; }
    }
}
