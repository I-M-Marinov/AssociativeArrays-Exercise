using System;
using System.Collections.Generic;

namespace P2.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int sumQuantity = 0;
            var resourcesMined = new Dictionary<string, int>();

            while (resource != "stop")
            {
                if (resourcesMined.ContainsKey(resource))
                {
                    sumQuantity = quantity + resourcesMined[resource];
                    resourcesMined[resource] = sumQuantity;
                }
                else
                {
                    resourcesMined.Add(resource, quantity);
                }

                resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }

                quantity = int.Parse(Console.ReadLine());

            }

            foreach (var entry in resourcesMined)
            {
                    Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }

        }
    }
}
