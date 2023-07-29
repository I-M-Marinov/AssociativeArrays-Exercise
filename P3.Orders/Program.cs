using System;
using System.Collections.Generic;
using System.Linq;


namespace P3.Orders
{
    
    class Product
    {
        public string Name { get; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public Product(string name, decimal price, decimal quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Name} -> {Price * Quantity:F2}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string,Product> productsList = new Dictionary<string, Product>();

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] tokens = input.Split(" ").ToArray();
                var productName = tokens[0];
                var price = decimal.Parse(tokens[1]);
                var quantity = decimal.Parse(tokens[2]);

                if (!productsList.ContainsKey(productName))
                {
                    var productItem = new Product(productName, price, quantity);
                    productsList.Add(productName, productItem);
                }
                else
                {
                    var existingProduct = productsList[productName];
                    existingProduct.Price = price;
                    existingProduct.Quantity += quantity;
                }
            }

            foreach (var productItem in productsList.Values)
            {
                Console.WriteLine(productItem);
            }
        }
    }
}
