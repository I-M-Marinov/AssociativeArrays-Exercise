using System;
using System.Collections.Generic;
using System.Linq;

namespace P4.SoftUniParking
{
    internal class Program
    {
        static void CheckInCheckOut(Dictionary<string, string> employees)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> command = Console.ReadLine().Split(" ").ToList();

                if (command[0] == "register")
                {
                    if (employees.ContainsKey(command[1]))
                    {
                        Console.WriteLine(
                            $"ERROR: already registered with plate number {employees.First(x => x.Key == command[1]).Value}");
                    }
                    else
                    {
                        employees.Add(command[1], command[2]);
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                }
                else if (command[0] == "unregister")
                {
                    if (employees.ContainsKey(command[1]))
                    {
                        employees.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                }
            }
        }

        static void Print(Dictionary<string, string> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Key} => {employee.Value}");
            }
        }

        static void Main(string[] args)
        {
            {
                var employees = new Dictionary<string, string>();
                CheckInCheckOut(employees);
                Print(employees);
            }

        }
    }
}