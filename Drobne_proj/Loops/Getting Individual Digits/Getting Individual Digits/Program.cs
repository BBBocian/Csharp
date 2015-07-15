using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Use nested for loops to generate a list of all the positive two digit numbers. Display the numbers, and the sums of their digits.

10. 1+0 = 1
11. 1+1 = 2
12. 1+2 = 3
13. 1+3 = 4
14. 1+4 = 5
15. 1+5 = 6
16. 1+6 = 7
17. 1+7 = 8
18. 1+8 = 9
19. 1+9 = 10
20. 2+0 = 2
21. 2+1 = 3
22. 2+2 = 4
.
.
.
.

97. 9+7 = 16
98. 9+8 = 17
99. 9+9 = 18
 */

namespace Getting_Individual_Digits
{
    class Program
    {
            public static void Main(string[] args)
            {
	        ///{Write your logic here
                int a,b,sum;
        
                for(int i=10;i<100;i++)
                {
                    a = i/10;
                    b = i%10;
                    sum = a+b;
                    Console.WriteLine("{0}. {1}+{2} = {3}",i,a,b,sum);
                }

            }
        
    }
}
