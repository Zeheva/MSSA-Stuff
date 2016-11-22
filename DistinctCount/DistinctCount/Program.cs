using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctCount
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string: ");
            string userString = Console.ReadLine();
            int answer = TestList.getDistinct(userString);
            Console.WriteLine("your string contains {0} distinct methods.", answer);
        }
        class TestList
        {
            
            public static int getDistinct(string userString)
            {
                List<char> charList = new List<char>();
                int i = userString.Length;
                List<char> newCharList = new List<char>();
                charList = userString.ToList();
                var distinctElement = charList.Distinct();

                foreach (var element in distinctElement)
                {
                    newCharList.Add(element);
                }
                char[] distinctArray = newCharList.ToArray();
                string resultString = new string(distinctArray);
                int distinctCount = resultString.Length;
                return distinctCount;
            }


           
        }
    }
}
