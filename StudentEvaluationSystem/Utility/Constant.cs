using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEvaluationSystem.Utility
{
    public class Constant
    {
        public const string AdminUser = "Admin";
        public const string RegularUser = "Regular";
        public const string StudentUser = "Student";
        public const string AdminAndRegularUser = "Admin,Regular";

        public const string JuniorClass = "Junior";
        public const string SeniorClass = "Senior";
        public const string SeniorClassScience = "Senior (Science)";
        public const string SeniorClassArt = "Senior (Art)";
        public const string SeniorClassCommercial = "Senior (Commercial)";

        public const string FirstTerm = "First Term";
        public const string SecondTerm = "Second Term";
        public const string ThirdTerm = "Third Term";
        
        public const string Updated = "Updated";
        public const string Saved = "Saved";
        public const string Uploaded = "Uploaded";

        public const string Promoted = "Promoted";
        public const string NotPromoted = "Not Promoted";
        public const string Graduated = "Graduated";
        public const string NotGraduated = "Could Not Graduate";

        public const double PassMark = 40;
        public const double NumberOfSubjectsToPass = 6;

        public const int JuniorClass_FK = 1;
        public const int JuniorFinalClassId = 4;
        public const int SeniorClass_FK = 5;
    }
}
