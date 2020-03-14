using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEvaluationSystem.Utility
{
    public static class GradingSystem
    {
        public static string GetGrade(double score)
        {
            if (score >= 80 && score <= 100)
                return "A1";

            if (score >= 70 && score <= 79)
                return "B2";

            if (score >= 65 && score <= 69)
                return "B3";

            if (score >= 60 && score <= 64)
                return "C4";

            if (score >= 55 && score <= 59)
                return "C5";

            if (score >= 50 && score <= 54)
                return "C6";

            if (score >= 45 && score <= 49)
                return "D7";

            if (score >= 40 && score <= 44)
                return "E8";

            else
                return "F9";
        }
    }
}
