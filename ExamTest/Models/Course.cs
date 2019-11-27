using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamTest.Models
{
    public class Course
    {
        public int c_id { get; set; }
        public string courseName { get; set; }
        public List<Question> exams { get; set; }

    }
}
