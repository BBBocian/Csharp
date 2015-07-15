using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Make a program which displays an appropriate name for a person, using a combination of nested if and compound conditions.

If the person is female and 20 or over, ask if she is married. If so, display "Mrs." in front of her name. If not, display "Ms." in front of her name. If the female is under 20, display her first and last name.

If the person is male and 20 or over, display "Mr." in front of his name. Otherwise, display his first and last name.

Note that asking a person if they are married should only be done if they are female and 20 or older, which means you will have a single if and else nested inside one of your if statements.

What is your gender (M or F): f
First name: Sara
Last name: Joseph
Age: 28
Are you married, Sara (y or n)?: y
Then I shall call you Mrs. Joseph.
 

What is your gender (M or F): f
First name: Kelly
Last name: Brown
Age: 12
Then I shall call you Kelly Brown.
 */ 

namespace Gender_Game
{
    class Program
    {
        public static void Main(string[] args)
        {
            char g, m;                                                                      // g=gender, m=married
            int a;                                                                          // a=age
            string fname, lname;
            Console.Write("What is your gender (M or F): ");
            g = Convert.ToChar(Console.ReadLine());
            Console.Write("First name: ");
            fname = Console.ReadLine();
            Console.Write("Last name: ");
            lname = Console.ReadLine();
            Console.Write("Age: ");
            a = int.Parse(Console.ReadLine());

            if (g == 'f' || g == 'F' & a > 20)
            {

                Console.WriteLine("Are you married {0} (y or n)?", fname);
                m = Convert.ToChar(Console.ReadLine());
                if (m == 'y' || m =='Y')
                    Console.Write("Then I shall call you Mrs. {0}.", lname);
                else
                    Console.Write("Then I shall call you Ms. {0}.", lname);
            }
            else if (g == 'm' || g == 'M')
            {
                if (a > 20)
                    Console.WriteLine("Then I shall call you Mr. {0}.", lname);
                else
                    Console.WriteLine("Then I shall call you {0}{1}.", fname, lname);
            }
            else
                Console.WriteLine("Then I shall call you {0}{1}.", fname, lname);

        }
    }
}
