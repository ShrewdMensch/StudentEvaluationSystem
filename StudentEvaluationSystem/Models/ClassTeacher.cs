using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEvaluationSystem.Models
{
    public class ClassTeacher
    {
        public int Id { get; set; }
        public int ClassId { get; set; }

        public int TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }


        [ForeignKey("ClassId")]
        public Class Class { get; set; }
    }
}
