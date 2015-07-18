using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that receives a string, the program then counts the number of words ending in 'y' or 'z'.

Enter string:fez day
Total words ending in y or z:2
 */

namespace COUNTyz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string:");
            string s = Console.ReadLine();
            int total=0;

            string[] split_tab = s.Split(' ');                                      // spliting string to substrings separated by space

            for (int i = 0; i < split_tab.Length; i++)                              // checking if in every substring last char is 'z' or 'y'
            {
                char lastCharInWord=split_tab[i][split_tab[i].Length - 1];

                if ( lastCharInWord == 'z' || lastCharInWord == 'y')
                    total += 1;
            }
       
            Console.WriteLine("Total words ending on y or z:{0}", total);
            Console.ReadLine();
        }
    }
}
