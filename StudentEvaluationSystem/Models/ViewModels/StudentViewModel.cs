using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace StudentEvaluationSystem.Models.ViewModels
{
    public class StudentViewModel
    {
        public Student Student { get; set; }

        public IEnumerable<SelectListItem> AvailableClasses { get; set; }
    }
}
