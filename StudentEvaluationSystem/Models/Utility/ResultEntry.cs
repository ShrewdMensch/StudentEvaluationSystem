using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEvaluationSystem.Models.Utility
{
    public class ResultEntry
    {

        public int StudentId { get; set; }

        [Display(Name = "Subject")]
        public int SubjectId { get; set; }

        [Display(Name = "Session-Term")]
        public int SessionTermId { get; set; }

        public int ClassId { get; set; }

        [Display(Name = "Test Score")]
        [Range(0, 30)]
        public double TestScore { get; set; }

        [Display(Name = "Exam Score")]
        [Range(0, 70)]
        public double ExamScore { get; set; }

        public string StudentName { get; set; }

        public string SubjectName { get; set; }
        public string ClassName { get; set; }
    }
}
