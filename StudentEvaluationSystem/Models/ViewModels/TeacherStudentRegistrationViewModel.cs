using Microsoft.AspNetCore.Mvc.Rendering;
using StudentEvaluationSystem.Models.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEvaluationSystem.Models.ViewModels
{
    public class TeacherStudentRegistrationViewModel
    {
        public StudentRegistrationViewModel StudentRegistrationViewModel { get; set; }

        public TeacherRegistration TeacherRegistartion { get; set; }
    }
}
