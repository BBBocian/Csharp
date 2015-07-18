using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Create an array that can hold ten integers, and fill each slot with a different random value from 1-50. 
 * Display those values on the screen, and then prompt the user for an integer. Search through the array, 
 * and if the item is present, say so. If the value was not found, display nothing. If the item is in the 
 * array multiple times, print the message more than once.*/

namespace Find_value_in_array
{
    class Program
    {
        static void Main()
        {

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 7, 9, 14 };
            Console.Write("Array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine("");
            Console.Write("Value to find:");
            int tofind = int.Parse(Console.ReadLine());
            //write your code here

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == tofind)
                    Console.WriteLine("{} is in the array", tofind);
            }
            Console.ReadLine();
        }
    }
}