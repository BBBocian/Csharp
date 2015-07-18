using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that receives two strings. If they are unequal in length, remove the first 'n' number of characters from the larger string until they are of the same size. Concatenate the two strings and display them.

 

Enter first string:cupcake
Enter second string:banana
upcakebanana
 */

namespace Make_the_Strings_Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first string:");
            string s1 = Console.ReadLine();
            Console.Write("Enter second string:");
            string s2 = Console.ReadLine();

            int len1 = s1.Length;
            int len2 = s2.Length;

            if(len1 > len2)
            {
                string conc = s1.Substring(len1-len2)+s2;
                Console.WriteLine(conc);
            }
            else if(len1 < len2)
            {
                string conc = s1 + s2.Substring(len2 - len1);
                Console.WriteLine(conc);
            }
            else
                Console.WriteLine(s1+s2);

            Console.ReadLine();
        }
    }
}
