using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ExamTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamTest.Pages
{
    public class TakeCourseModel : PageModel
    {
        public Course course { get; set; }
        private string basepath = "./././wwwroot";
        public int questionAmt { get; set; } = 20;

        string fullNumPath { get; set; }
        string fullTextPath { get; set; } 
        string fullBinaryPath { get; set; } 

        [BindProperty]
        public string ExamType { get; set; }
        private DataModel dataModel { get; set; }
        public void OnGet(string id)
        {
            fullNumPath = basepath + "/Number.json";
            fullTextPath = basepath + "/Text.json";
            fullBinaryPath = basepath + "/Binary.json";
            if (!string.IsNullOrEmpty(id))
            {
                this.ExamType = id;
            }
            switch (id)
            {
                case "text": GetTextQuestions(questionAmt); break;
                case "numbers": GetNumberQuestions(questionAmt); break;
                case "binary": GetBinaryQuestions(questionAmt); break;
                default: course = new Course(); break;
            }
        }
        public IActionResult OnPost()
        {
            Scoreboard scoreBoard = null; dynamic answers = null;

            fullNumPath = basepath + "/Number.json";
            fullTextPath = basepath + "/Text.json";
            fullBinaryPath = basepath + "/Binary.json";

            if (ExamType == "text")
            {
                GetTextQuestions(questionAmt);
                 answers = Request.Form["text"].ToList();
                scoreBoard = new Scoreboard(course, answers);
            }
            else if (ExamType == "numbers")
            {
                GetNumberQuestions(questionAmt);
                 answers = Request.Form["numbers"].ToList();
                scoreBoard = new Scoreboard(course, answers);
            }
            else
            {
                GetBinaryQuestions(questionAmt);
                answers = Request.Form["binary"].ToList();
                scoreBoard = new Scoreboard(course, answers);
            }
            return RedirectToPage("result", scoreBoard.ToString());
        }
       
        private void GetBinaryQuestions(int questionAmt)
        {
            dataModel = new DataModel(fullBinaryPath);
            course = dataModel.GetCourse();
        }

        private void GetNumberQuestions(int questionAmt)
        {
            dataModel = new DataModel(fullNumPath);
            course = dataModel.GetCourse();
        }

        private void GetTextQuestions(int questionAmt)
        {

            dataModel = new DataModel(fullTextPath);
            course = dataModel.GetCourse();
        }
    }
}