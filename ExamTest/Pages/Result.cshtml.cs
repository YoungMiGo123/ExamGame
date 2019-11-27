using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamTest.Pages
{
    public class ResultModel : PageModel
    {
        public string result { get; set; }
        public void OnGet(string result)
        {
            this.result = Request.Query.FirstOrDefault().Value;
        }
    }
}