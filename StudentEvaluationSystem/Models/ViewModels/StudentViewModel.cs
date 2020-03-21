using StudentEvaluationSystem.Models.Utility;
using System.Collections.Generic;

namespace StudentEvaluationSystem.Models.ViewModels
{
    public class StudentViewModel
    {
        public Student Student { get; set; }

        public IEnumerable<ClassDropDownItem> AvailableClasses { get; set; }
    }
}
