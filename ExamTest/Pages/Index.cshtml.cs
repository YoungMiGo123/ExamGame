using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ExamTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public DataModel dataModel { get; set; }
        private string basepath = "./././wwwroot";
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            try
            {
                string fullNumPath = basepath + "/Number.json";
                string fullTextPath = basepath + "/Text.json";
                string fullBinaryPath = basepath + "/Binary.json";
                dataModel = new DataModel(fullBinaryPath);
                var case1 = dataModel.GetCourse();
                if (case1 == null)
                {
                    var course1 = new Course()
                    {
                        c_id = 0,
                        courseName = "Binary Exam",
                        exams = new List<Question>()
                {
                    new Question()
                    {
                        q_id = 0,
                        type = "binary",
                        question = "What state is a light bulb in when it's on",
                        answer = 1
                    },
                    new Question()
                    {
                        q_id = 1,
                        type = "binary",
                        question = "What state would a car have if its off ?",
                        answer = 0,

                    },
                    new Question()
                    {
                        q_id = 2,
                        type = "binary",
                        question = "What state is a computer when it's on",
                        answer = 1
                    }


                }
                    };
                    dataModel.AddCourse(course1);
                }
               
                dataModel = new DataModel(fullNumPath);
                var case2 = dataModel.GetCourse();
                if(case2 == null)
                {
                    var course2 = new Course()
                    {
                        c_id = 0,
                        courseName = "Numbers Exam",
                        exams = new List<Question>()
                {
                    new Question()
                    {
                        q_id = 3,
                        type = "numbers",
                        question = "What's 2x2",
                        answer = 4
                    },
                    new Question()
                    {
                        q_id = 4,
                        type = "numbers",
                        question = "What's the Square root of 64 ?",
                        answer = 8,

                    },
                    new Question()
                    {
                        q_id = 5,
                        type = "numbers",
                        question = "What's the square of 4",
                        answer = 4*4
                    }


                }
                    };

                    dataModel.AddCourse(course2);
                }
              
                dataModel = new DataModel(fullTextPath);
                var case3 = dataModel.GetCourse();
                if(case3 == null)
                {
                    var course3 = new Course()
                    {
                        c_id = 0,
                        courseName = "Text Exam",
                        exams = new List<Question>()
                {
                    new Question()
                    {
                        q_id = 4,
                        type = "text",
                        question = "Who's the current president of South Africa ?",
                        answer = "cyril ramaposa"
                    },
                    new Question()
                    {
                        q_id = 5,
                        type = "text",
                        question = "Who was the first black president in South Africa ?",
                        answer = "nelson mandela",

                    },
                    new Question()
                    {
                        q_id = 6,
                        type = "text",
                        question = "Who invented the Macbook",
                        answer = "steve jobs"
                    }


                }
                    };
                    dataModel.AddCourse(course3);
                }

            }
            catch (Exception e)
            {

            }
        }

        public void OnGet()
        {

        }
    }
}
