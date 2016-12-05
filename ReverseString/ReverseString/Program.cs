using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a string: ");
            string s = Console.ReadLine();
            
            Console.WriteLine(s.Reverse());
        }
    }
}
