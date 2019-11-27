using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamTest.Models
{
    public class Question
    {
        public int q_id { get; set; }
        public string type { get; set; }

        public string question { get; set; }
        public dynamic answer { get; set; }

            
    }
}
