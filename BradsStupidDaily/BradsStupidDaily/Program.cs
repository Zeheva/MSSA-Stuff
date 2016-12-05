using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BradsStupidDaily
{
    class Program
    {
        static void Main(string[] args)
        {
            string yn = "y";
            while (yn == "y")
            {
                Console.WriteLine("Enter an integer: ");
                int num = int.Parse(Console.ReadLine());
                for (int i = num; i >= 0; i--)
                {
                    for (int x = i; x > 0; x--)
                    {
                        Console.Write(num);
                    }
                    Console.WriteLine();
                }
                Console.Write("Do you want to try another integer? (y/n): ");
                yn = Console.ReadLine();
            }          
        }
    }
}
