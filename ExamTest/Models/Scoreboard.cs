using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamTest.Models
{
    public class Scoreboard
    {
        public double UserScore { get; set; } 
        public double TotalExamCount { get; set; }
        public Course course { get; set; }
        public List<string> answers { get; set; }
        public Scoreboard(Course userCourse, List<string> answers)
        {
            this.TotalExamCount = userCourse.exams.Count;
            this.course = userCourse;
            this.answers = answers;
            UserScore = CalculateScore();
        }
        public double CalculatePercentage()
        {
            return (UserScore / TotalExamCount) * 100;
        }
        private double CalculateScore()
        {
            double count = 0;
            dynamic userAnswer;
            for (int i = 0; i < course.exams.Count; i++)
            {
                var actualAnswer = course.exams[i];
                if (actualAnswer.type != "text")
                {
                    userAnswer = Convert.ToInt32(answers[i]);
                }
                else
                {
                    userAnswer = answers[i].ToLower();
                }

                if (actualAnswer.answer == userAnswer) count++;

            }
            return count;

        }
        public override string ToString()
        {
            var result = $"<h1>Thank, you for Completing: {course.courseName}</h1>";
            result += $"<h4>Your Score {CalculatePercentage()} %</h4>";
            result += "<br /><div class='row'>";
            int temp = 0;
            for (int i = 0; i < course.exams.Count; i++)
            {
                result += "<div class='col-12'>";
                result += $"<h4>Question {i} -> {course.exams[i].question} </h4>";
                result += $"<div class='row'><div class='col-4'><h5> Actual Answer </ h5 ><p> {course.exams[i].answer} </p> </div>";
                result += $"<div class='col-4'><h5> Your Answer </ h5 ><p> {answers[i]} </p> </div></div>";
                if(course.courseName != "Text Exam")
                {
                    temp = Convert.ToInt32(answers[i]);
                    if (temp == course.exams[i].answer)
                    {
                        result += "<button class='btn-primary'> Correct</button>";

                    }
                    else
                    {
                        result += "<button class='btn-danger'> Incorrect</button>";
                    }
                }
                else
                {
                    if (answers[i] == course.exams[i].answer)
                    {
                        result += "<button class='btn-primary'> Correct</button>";

                    }
                    else
                    {
                        result += "<button class='btn-danger'> Incorrect</button>";
                    }

                }
                result += "</div>";
            }
            result += "</div>";

            return result;
        }
    }
}
