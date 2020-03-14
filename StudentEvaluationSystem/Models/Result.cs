using StudentEvaluationSystem.Utility;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEvaluationSystem.Models
{
    public class Result
    {
        public int Id { get; set; }

        [Display(Name = "Student")]
        public int StudentId { get; set; }

        [Display(Name = "Class")]
        public int ClassId { get; set; }

        [Display(Name = "Subject")]
        public int SubjectId { get; set; }


        public int SessionTermId { get; set; }

        [Display(Name = "Test Score")]
        [Range(0,30)]
        public double TestScore { get; set; }

        [Display(Name = "Exam Score")]
        [Range(0, 70)]
        public double ExamScore { get; set; }

        public double Total => ExamScore + TestScore;

        public string Grade => GradingSystem.GetGrade(Total);
        
        [ForeignKey("SessionTermId")]
        public SessionTerm SessionTerm { get; set; }

        [ForeignKey("ClassId")]
        public Class Class { get; set; }

        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }

        public Student Student { get; set; }

       

    }
}
