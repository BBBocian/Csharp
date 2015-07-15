using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that creates an array which can hold ten values. 
 * Fill the array with numbers from 1 to 100. Use a linear search to find the 
 * largest value in the array, and display that value. */


namespace Finding_the_Largest_Value_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();                                      // list to contain values from user

            for (int i = 0; i < 10; i++)                                            // loop to get values from user
            {
                lista.Add(int.Parse(Console.ReadLine()));                           // adding all values from input to list
            }

            Console.WriteLine("The largest value is {0}",lista.Max());             // printing largest value

            Console.ReadLine();
        }
    }
}
