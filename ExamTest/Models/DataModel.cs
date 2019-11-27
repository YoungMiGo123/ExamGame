using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ExamTest.Models
{
    public class DataModel
    {

        public string path { get; set; }
        public DataModel(string path)
        {
            this.path = path;
            streamReader = new StreamReader(path);

        }

        private StreamReader streamReader { get; set; }
        private StreamWriter streadWriter { get; set; }
        public void AddCourse(Course course)
        {
            try
            {
                streamReader.Close();
                streadWriter = new StreamWriter(path);
                var obj = JsonConvert.SerializeObject(course);
                streadWriter.WriteLine(obj);
                streadWriter.Close();
            }
            catch (Exception e) { }
        }
        public void AddQuestionToCourse(Question question)
        {
            try
            {
                var courseData = streamReader.ReadToEnd();

                var processedData = JsonConvert.DeserializeObject<Course>(courseData);
                var exams = processedData.exams;

                exams.Add(question);
                processedData.exams = exams;
                streamReader.Close();
                streadWriter = new StreamWriter(path);

                var obj = JsonConvert.SerializeObject(processedData);
                streadWriter.WriteLine(obj);
                streadWriter.Close();

            }
            catch (Exception e)
            {

            }
        }

        public void RemoveQuestion(Question question)
        {
            try
            {
                var courseData = streamReader.ReadToEnd();
                streamReader.Close();
                streadWriter = new StreamWriter(path);
                var processedData = JsonConvert.DeserializeObject<Course>(courseData);
                processedData.exams.RemoveAll(x => x.question == question.question); streamReader.Close();
                var obj = JsonConvert.SerializeObject(processedData);
                streadWriter.WriteLine(obj);
                streadWriter.Close();
            }
            catch (Exception e)
            {

            }
        }
        public Course GetCourse()
        {
            try
            {
                var courseData = streamReader.ReadToEnd();
                streamReader.Close();
                var processedData = JsonConvert.DeserializeObject<Course>(courseData);
                return processedData;
            }
            catch (Exception e)
            {

            }

            return new Course();
        }




    }
}

