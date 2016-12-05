using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegExDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "y";
            while (s == "y")
            {
                Console.WriteLine("Please enter your first name:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Please enter your last name:");
                string lastName = Console.ReadLine();
                string pattern = @"[A-Z][a-z]+";

                Match firstMatch = Regex.Match(firstName, pattern);
                Match lastMatch = Regex.Match(lastName, pattern);

                if (firstMatch.Success == true && lastMatch.Success == true)
                {
                    Console.WriteLine("Your full name is {0} {1}.", firstName, lastName);
                }
                else
                    Console.WriteLine("The inputs you provided are not valid names.");
                Console.Write("Do you want to try again? (y/n): ");
                s = Console.ReadLine();
            }
            
            
        }
        
    }
}
