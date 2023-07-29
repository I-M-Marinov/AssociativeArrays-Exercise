using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P7.CompanyUsers
{
    public class Company
    {
        public List<string> employeeID = new List<string>();

        public Company(string name)
        {
            Name = name;
            employeeID = new List<string>();
        }

        public string Name { get; set; }

        public void AddID(string id)
        {
            employeeID.Add(id);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(Name);
            foreach (var ID in employeeID)
            {
                sb.AppendLine($"-- {ID}");
            }
            return sb.ToString();
        }
        public static void AddCompanies(List<Company> companies)
        {
            string comandArg = string.Empty;

            while ((comandArg = Console.ReadLine()) != "End")
            {
                List<string> companyArg = comandArg.Split(" -> ").ToList();

                string name = companyArg[0];
                string id = companyArg[1];
                Func<Company, bool> isNamenListed = n => n.Name == name;

                if (companies.Any(isNamenListed) == false)
                {
                    var company = new Company(name);
                    company.AddID(id);
                    companies.Add(company);
                }
                else
                {
                    if (ContainID(companies, companyArg) == false)
                    {
                        companies.First(n => n.Name == name).AddID(id);
                    }
                }
            }
        }

        public static void PrintCompanies(List<Company> companys)
        {

            foreach (var company in companys)
            {
                Console.Write(company);
            }
        }
        public static bool ContainID(List<Company> companies, List<string> companyArg)
        {
            string name = companyArg[0];
            string id = companyArg[1];
            return companies.First(n => n.Name == name).employeeID.Contains(id);
        }
        internal class Program
    {
        static void Main(string[] args)
        {
            var companies = new List<Company>();

            AddCompanies(companies);
            PrintCompanies(companies);
        }
       
    }

    
    }
}
