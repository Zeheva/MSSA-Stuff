using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTrimmer
{
    class Program
    {
        static void Main(string[] args)
        {
            string YesNo = "y";
            while (YesNo == "y")
            {
                Console.WriteLine("Enter a string you want trimmed: ");
                Console.WriteLine();
                string startString = Console.ReadLine();
                Console.WriteLine(StringTrimmer.Remove_char2(startString));
                Console.WriteLine();
                Console.Write("Do you want to trim another string? (y/n): ");
                YesNo = Console.ReadLine();
            }


        }

        public class StringTrimmer
        {
            public static string Remove_char1(string startString)
            {
                char[] charArray = startString.ToArray();
                List<char> charList = new List<char>();
                int length = charArray.Length;
                int newLength = length - 2;

                for (int i = 1; i < length - 1; i++)
                {
                    charList.Add(charArray[i]);
                }

                char[] newCharArray = new char[newLength];
                newCharArray = charList.ToArray();
                string endString = new string(newCharArray);
                return endString;
            }

            public static string Remove_char2(string startString)
            {
                char[] charArray = startString.ToArray();
                int length = charArray.Length;
                int newLength = length - 2;
                char[] newCharArray = new char[newLength];
                int j = 0;
                for (int i = 1; i < length - 1; i++)
                {
                    newCharArray[j] = charArray[i];
                    j++;
                }
                string endString = new string(newCharArray);
                return endString;
            }
        }
    }
}
