using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Write("Enter a containing numbers:");
            string s = Console.ReadLine() ;
            int total = 0;
            string[] substrings1;
            string[] substrings2;


            
            substrings1 = Regex.Split(s, @"\D+", RegexOptions.IgnoreCase);
                //substrings2 = Regex.Split(substrings1[1], @"\D+");

              /*  for (int i = 0; i < substrings1.Length; i++)
                {
                    total += Convert.ToInt32(substrings1[i]);
                }*/
            
                foreach(string x in substrings1)
                    Console.WriteLine(x);

            



         //   Console.WriteLine("Total sum:" + total);
            Console.ReadLine();

        }
   
            
      
        
    }
}
