using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        //commit test comment for Git..
        static void Main(string[] args)
        {
            int[] arr = { 4, 7, 1, 6, 10, 2, 9, 8, 5, 3};
            {
                int temp;
                int upper = arr.Length;
                for (int outer = 0; outer < upper - 1; outer++)
                {
                    for (int inner = outer + 1; inner < upper; inner++)
                    {
                        if (arr[inner] < arr[outer])
                        {
                            temp = arr[inner];
                            arr[inner] = arr[outer];
                            arr[outer] = temp;
                            for (int i = 0; i < upper; i++)
                            {
                                Console.Write(arr[i] + ", ");
                                
                            }
                            Console.WriteLine();
                        }
                    }
                }
               
                Console.ReadLine();
            }
        }
    }
}
