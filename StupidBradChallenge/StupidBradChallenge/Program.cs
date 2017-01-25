using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidBradChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            if (stringTest(Console.ReadLine()) == true)
                {
                Console.WriteLine("String has repeating characters.");
                }
            else Console.WriteLine("All characters are unique.");
        }

        public static bool stringTest(string str)
        {
            bool b = false;
            int n = 1;
            int l = str.Length;
            foreach (var item in str)
            {               
                
                for (int i = n; i < l; i++)
                {                    
                    if (item == str[i])
                        b = true;                   
                }
                n++;                
            }
            return b;
        }
    }
}
