using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Take any natural number n.

If n is even, divide it by 2 to get n / 2.
If n is odd, multiply it by 3 and add 1 to get 3n + 1.
Repeat the process indefinitely.
In 1937, Lothar Collatz proposed that no matter what number you begin with, the sequence eventually reaches 1. This is widely believed to be true, but has never been formally proved.

Write a program that inputs a number from the user, and then displays the Collatz Sequence starting from that number. Stop when you reach 1. It should also count the steps that it takes to get to 1.

Starting number:
5
5 16 8 4 2 1
Terminated after:5 steps



Starting number:
-1
Only positive numbers
Terminated after:0 steps
 */

namespace Collatz_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Starting number:");
            int n = int.Parse(Console.ReadLine());
            int steps = 0;
            List<int> lista = new List<int>();
            while(n != 1)
            {
                
                if (n % 2 == 0)
                    n = n / 2;
                else
                    n = 3 * n + 1;
                steps += 1;
                lista.Add(n);
            }

            foreach (int x in lista)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine("Terminated after:{0} steps", steps);
            Console.ReadLine();

        }
    }
}
