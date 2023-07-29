using System;
using System.Collections.Generic;


namespace P1.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            string trim = text.Replace(" ", "");

            var charactersCount = new Dictionary<char, int>();

            foreach (char c in text)
            {

                if (c != ' ')
                {
                    if (charactersCount.ContainsKey(c))
                    {
                        charactersCount[c]++;
                    }
                    else
                    {
                        charactersCount[c] = 1;
                    }
                }
            }

            foreach (var entry in charactersCount)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }

    }

}

    