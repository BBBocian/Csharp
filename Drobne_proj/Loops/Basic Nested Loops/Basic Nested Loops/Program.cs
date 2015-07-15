using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Use some simple nested for loops to generate all possible coordinates from (0 0) up to (5 5). Your output must appear in rows and columns as shown below.

Note: There is no space after the last column.

(0 0) (0 1) (0 2) (0 3) (0 4) (0 5)
(1 0) (1 1) (1 2) (1 3) (1 4) (1 5)
(2 0) (2 1) (2 2) (2 3) (2 4) (2 5)
(3 0) (3 1) (3 2) (3 3) (3 4) (3 5)
(4 0) (4 1) (4 2) (4 3) (4 4) (4 5)
(5 0) (5 1) (5 2) (5 3) (5 4) (5 5)
 */

namespace Basic_Nested_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int k = 0; k < 6; k++)
                {
                    Console.Write("({0}{1})", i, k);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
