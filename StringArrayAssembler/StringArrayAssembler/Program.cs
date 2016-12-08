using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayAssembler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[] { "a", "c", "e", "g", "h" };
            string[] array2 = new string[] { "b", "d", "f", "i", "j" };
            List<string> list3 = new List<string>(array1.Concat<string>(array2));

            foreach (var item in list3)
            {
                Console.Write(item);               
            }

            Console.WriteLine();
            list3.Sort();

            foreach (var item in list3)
            {
                Console.Write(item);
            }
            Console.ReadLine();            
        }        
    }
}
