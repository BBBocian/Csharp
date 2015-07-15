using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Make a program which displays a different message depending on the age given.

age is less than 16, say "You can't drive."

age is less than 18, say "You can't vote."

age is less than 25, say "You can't rent a car."

age is 25 or over, say "You can do anything that's legal."

Hey, what's your name?: John
Ok, John, how old are you?: 19
You can't rent a car John.
 

Hey, what's your name?: Smith
Ok, Smith, how old are you?: 13
You can't drive Smith.
You can't vote Smith.
You can't rent a car Smith.
 */ 

namespace How_Old_Are_You
{
    class Program
    {
        public static void Main(string[] args)
        {
            int age;
            string name;
            Console.Write("Hey, what's your name?: ");
            name = Console.ReadLine();
            Console.Write("Ok, {0}, how old are you?: ", name);
            age = int.Parse(Console.ReadLine());

            string[] tab = new string[] { "You can't drive", "You can't vote", "You can't rent a car", "You can do anything that's legal" };

            if (age < 25)
            {
                if (age < 18)
                {
                    if (age < 16)
                    {
                        Console.WriteLine("{0}{1}.", tab[0], name);
                    }
                    Console.WriteLine("{0}{1}.", tab[1], name);
                }
                Console.WriteLine("{0}{1}.", tab[2], name);
            }
            else
                Console.WriteLine("{0}{1}.", tab[3], name);
        }

    }  
}
