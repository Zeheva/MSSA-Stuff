using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsogramTester
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesNo = "y";
            while (yesNo == "y")
            {
                Console.WriteLine("Enter a string to test: ");
                string s = Console.ReadLine();
                char[] inputArray = new char[s.Length];
                inputArray = s.ToCharArray();

                int test = 0;
                int position = 0;
                foreach (var item in inputArray)
                {
                    for (int i = position + 1; i < s.Length; i++)
                        if (test == 0)
                        {
                            {
                                if (item == inputArray[i])
                                {
                                    test = 1;
                                }

                                if (test == 1)
                                {
                                    Console.WriteLine("{0} is not an isogram.", s);
                                }
                            }
                        }
                    position++;
                }

                if (test == 0)
                {
                    Console.WriteLine("{s} is an Isogram.", s);
                }

                Console.Write("Do you want to test another string? (y/n): ");
                yesNo = Console.ReadLine();
            }           
        }
    }
}
