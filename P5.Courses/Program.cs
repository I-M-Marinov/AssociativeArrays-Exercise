using System;
using System.Collections.Generic;
using System.Linq;

namespace P5.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            AddToDictionary(courses);
            Print(courses);
        }
        public static void Print(Dictionary<string, List<string>> courses)
        {
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var item in course.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }

        public static void AddToDictionary(Dictionary<string, List<string>> courses)
        {
            var command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> inputList = command.Split(" : ").ToList();
                string course = inputList[0];
                string student = inputList[1];

                if (courses.ContainsKey(course))
                {
                    if (courses.First(k => k.Key == course).Value.Contains(student) == false)
                    {
                        courses.First(k => k.Key == course).Value.Add(student);
                    }
                }
                else
                {
                    courses.Add(course, new List<string>() { student });
                }
            }
        }
    }
}