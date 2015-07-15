using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Use nested for loops to generate a list of all the two digit numbers which are less than or equal to fifty-six, and the sum of whose digits is greater than ten.

Use another set of nested for loops to find a two-digit number such that the number itself minus the number reversed is equal to the sum of its digits.

For example, 72 is not such a number because 72-27 (which is 45) is not the same as the sum of its digits (2+7 = 9).

Finally, put the code for each of the two parts into its own separate function, and have a menu in main() which allows you to choose which of the two sets to find. This main program should keep repeating until you choose to quit (use a do-while loop for this).

1) Find two digit numbers <=56 with sum of digits>10:
2) Find two digit numbers such that the number itself minus the number reversed is equal to the sum of its digits:
3) Quit:
>2
54
1) Find two digit numbers <=56 with sum of digits>10:
2) Find two digit numbers such that the number itself minus the number reversed is equal to the sum of its digits:
3) Quit:
>1
29
38
39
47
48
49
56
1) Find two digit numbers <=56 with sum of digits>10:
2) Find two digit numbers such that the number itself minus the number reversed is equal to the sum of its digits:
3) Quit:
>3
 */

namespace More_Number_Puzzles
{
    class Program
    {
        static void Main()
        {
            int option;
            bool condition = true;

            do
            {
                Console.WriteLine("1) Find two digit numbers <=56 with sum of digits>10:");
                Console.WriteLine("2) Find two digit numbers such that the number itself minus the number reversed is equal to the sum of its digits:");
                Console.WriteLine("3) Quit:");

                option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        findGreaterDigits();
                        break;
                    case 2:
                        findMinusNumber();
                        break;
                    case 3:
                        condition = false;
                        break;
                }

            } while (condition);

            Console.ReadLine();
        }

        public static void findGreaterDigits()
        {
            for (int i = 10; i <= 56; i++)
            {
                int i1 = i / 10;
                int i2 = i % 10;
                if (i1 + i2 > 10)
                    Console.WriteLine(i);

            }
        }

        public static void findMinusNumber()
        {
            for (int i = 10; i < 100; i++)
            {
                int i1 = i / 10;
                int i2 = i % 10;
                int i3 = i2 * 10;
                i3 += i1;
                if ((i - i3) == (i2 + i1))
                    Console.WriteLine(i);
            }
        }
    }
}
