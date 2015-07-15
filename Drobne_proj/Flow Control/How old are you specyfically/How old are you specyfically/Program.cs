using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Using if statements, else if, and else statements, make a program which displays a different message depending on the age given.

less than 16: You can't drive

greater than or equal to 16, but less than or equal to 17: You can drive but not vote

greater than 17, but less than or equal to 24: You can vote but not rent a car

greater than 24: You can do pretty much anything

Hey, what's your name?:john
Ok John. How old are you?:16
You can drive but not vote John.
 

Hey, what's your name?:Sam
Ok Sam. How old are you?:18
You can vote but not rent a car Sam.
 */ 

namespace How_old_are_you_specyfically
{
    class Program
    {
        public static void Main(string[] args)
        {
            int age;
            string name;

            // Console.WriteLine("Hey, what's your name?");
            name = Console.ReadLine();
            // Console.WriteLine("Ok {0}. How old are you?",name);
            age = int.Parse(Console.ReadLine());


            if (age < 16)
                Console.WriteLine(" You can't drive {0}.", name);
            else if (age >= 16 & age <= 17)
                Console.WriteLine("You can drive but not vote {0}.", name);
            else if (age > 17 & age <= 24)
                Console.WriteLine("You can vote but not rent a car {0}.", name);
            else
                Console.WriteLine("You can do pretty much anything {0}.", name);

        }
    }
}
