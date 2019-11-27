using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamTest.Models;
using ExamTest.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamTest.Pages
{
    public class AddQuestionModel : PageModel
    {
        [BindProperty]
        public string type { get; set; }
        [BindProperty]
        public Question question { get; set; }
        [BindProperty]
        public bool flag { get; set; }
        [BindProperty]
        public string Answer { get; set; }
        public void OnGet(bool flag)
        {
            this.flag = flag;
            this.type = Request.Query.FirstOrDefault().Value;
        }
        public IActionResult OnPost()
        {
            question.q_id = new Random().Next(6, 10000);
            question.answer = Answer;
            type = question.type;
            DataModel dataModel;
            if (type == "text")
            {
                dataModel = new DataModel(PathManager.fullTextPath);
                dataModel.AddQuestionToCourse(question);
                flag = true;
                return RedirectToPage("/index");
            }
            else if (type == "numbers")
            {
                dataModel = new DataModel(PathManager.fullNumPath);
                dataModel.AddQuestionToCourse(question);
                flag = true;
                return RedirectToPage("/index");
            }
            else
            {
                dataModel = new DataModel(PathManager.fullBinaryPath);
                dataModel.AddQuestionToCourse(question);
                flag = true;
               return RedirectToPage("/index");
            }
        }
   
    }
}