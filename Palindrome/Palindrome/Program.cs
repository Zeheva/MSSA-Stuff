using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesNo = "y";
            while (yesNo == "y" || yesNo == "Y")
            {
                Console.Write("Please enter a word: ");
                string word = Console.ReadLine();
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                string reverseWord = new string(charArray);

                if (word == reverseWord)
                {
                    Console.WriteLine(word + " is a palindrome!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Sorry, " + word + " is not a palindrome.");
                    Console.WriteLine();
                }
                Console.Write("Do you want to check another word? (y/n): ");
                yesNo = Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}
