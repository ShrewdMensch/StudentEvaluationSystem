using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEvaluationSystem.Models.Utility
{
    public class ClassTeacherEdit
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Class")]
        public int ClassId { get; set; }

        [Required]
        [Display(Name="Class Teacher")]
        public int TeacherId { get; set; }

        public int ClassTeacherId { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
    }
}
