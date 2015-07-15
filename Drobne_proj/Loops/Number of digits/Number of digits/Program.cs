using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that counts number of digits within a number given by the user.

Enter a number:1234323
The number of digits is 7
 */

namespace Number_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, count = 0;
            Console.Write("Enter a number:");
            num = int.Parse(Console.ReadLine());
            ///{Write your logic here

            string number = num.ToString();

            for (int i = 0; i < number.Length; i++)
            {
                if (Char.IsDigit(number[i]))
                    count += 1;
            }



            ///}
            Console.WriteLine("The number of digits is {0}", count);
        }
    }
}
