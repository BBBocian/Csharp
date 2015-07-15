using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that uses a for loop. With the loop, use the variable x to go from -10 to 10, counting by 0.5

Inside the body of the loop, use y to get the value of x squared. Then display the current values of both x and y.

 

-10    100
-9.5    90.25
-9    81
-8.5    72.5
-8    64
-7.5    56.25
-7    49
-6.5    42.25
-6    36
-5.5    30.25
-5    25
-4.5    20.25
-4    16
-3.5    12.25
-3    9
-2.5    6.25
-2    4
-1.5    2.25
-1    1
-0.5    0.25
0    0
0.5    0.25
1    1
1.5    2.25
2    4
2.5    6.25
3    9
3.5    12.25
4    16
4.5    20.25
5    25
5.5    30.25
6    36
6.5    42.25
7    49
7.5    56.25
8    64
8.5    72.25
9    81
9.5    90.25
10   100
 */

namespace Xs_and_Ys
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double i = -10; i < 10.5; i+=0.5 )
            {
                Console.WriteLine("{0} {1}",i,Math.Pow(i,2));
            }
            Console.ReadLine();
        }
    }
}
