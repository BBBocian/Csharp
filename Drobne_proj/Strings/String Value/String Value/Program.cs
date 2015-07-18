using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that receives a string and returns the total sum of the ASCII decimal values of its characters.

Enter string to count value:Thats mine!
Total value:1006
 */

namespace String_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string to count value:");
            string s = Console.ReadLine();
            double total = 0;
            //write your code here

            for (int i = 0; i < s.Length; i++)
            {
                total += (int)s[i];
                
            }

            //
            Console.WriteLine("Total value:{0}", total);
            Console.ReadLine();
        }
    }
}
