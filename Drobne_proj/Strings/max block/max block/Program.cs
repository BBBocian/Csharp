using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_block
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string:");
            string s = Console.ReadLine();
            List<int> lengths = new List<int>();
            int counter = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    counter += 1;
                    lengths.Add(counter);
                }
                else if (s.Length==0)
                    lengths.Add(1);
                else
                {
                    counter = 1;
                    lengths.Add(counter);
                }
                
            }
            int t = lengths.Max();



            Console.WriteLine("Largest block:{0}", t);
            Console.ReadLine();
        }
    }
}
