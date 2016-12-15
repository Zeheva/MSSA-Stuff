using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToggleTest
{
    class Program
    {
        /*Intent of code snippet is to demonstrate use of the 
        exclusive-OR operator to 'toggle' a binary condition.*/
        static void Main(string[] args)
        {
            bool toggle = false;
            for (int i = 0; i < 10; i++)
            {
                if (toggle != true)
                {
                    Console.WriteLine("Toggle is off.");
                }
                else
                {
                    Console.WriteLine("Toggle is on.");
                }
                toggle ^= true;
                
            }          
        }
    }
}
