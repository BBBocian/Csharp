using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that receives two strings. Remove the first character of each of the string and combine 
 * them. Display it. If the length of string entered is <=1, display the message: "String must be greater than 1"

First String:Im
Second String:hungry
mungry
 */

namespace New_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1;
            string s2;

            Console.Write("First String:");
            s1 = Console.ReadLine();
            Console.Write("Second String:");
            s2 = Console.ReadLine();

            if (s1.Length <= 1 || s2.Length <= 1)
                Console.WriteLine("String must be greater than 1");
            else
            {
                Console.WriteLine(s1.Remove(0, 1) + s2.Remove(0, 1));
            }

        }
    }
}
