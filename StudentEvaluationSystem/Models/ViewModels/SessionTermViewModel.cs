using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEvaluationSystem.Models.ViewModels
{
    public class SessionTermViewModel
    {
        public SessionTerm SessionTerm { get; set; }
        public List<Term> Terms { get; set; }
        public List<Session> Sessions { get; set; }
    }
}
