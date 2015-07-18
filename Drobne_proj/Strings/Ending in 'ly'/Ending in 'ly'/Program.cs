using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that receives a string. If the string ends in "ly" it displays true, otherwise it displays false.

String:endlessly
True
 */

namespace Ending_in__ly_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String:");
            string s1 = Console.ReadLine();

            if (s1.Substring(s1.Length - 2) == "ly")
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
