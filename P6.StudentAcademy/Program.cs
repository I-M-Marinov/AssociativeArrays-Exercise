using System;
using System.Collections.Generic;
using System.Linq;

namespace P6.StudentAcademy
{
    internal class Program
        {
            public static void PrintStudentsAverageGrade(Dictionary<string, List<double>> students)
            {
                foreach (var student in students)
                {
                    double averageGrade = student.Value.Sum() / student.Value.Count;
                    if (averageGrade >= 4.50)
                    {
                        Console.WriteLine($"{student.Key} -> {averageGrade:f2}");
                    }
                }
            }

            public static void ListStudents(Dictionary<string, List<double>> students)
            {
                int numberOfLines = int.Parse(Console.ReadLine());
                for (int i = 0; i < numberOfLines; i++)
                {
                    string student = Console.ReadLine();
                    double grade = double.Parse(Console.ReadLine());

                    if (students.ContainsKey(student))
                    {
                        students[student].Add(grade);
                    }
                    else
                    {
                        students.Add(student, new List<double>() { grade });
                    }
                }
            }
        static void Main(string[] args)
            {
                var students = new Dictionary<string, List<double>>();
                ListStudents(students);
                PrintStudentsAverageGrade(students);
            }
            
        }
    }