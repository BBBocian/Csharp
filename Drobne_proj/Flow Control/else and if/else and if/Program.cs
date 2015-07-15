using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that receives inputs from the user and prints the output according to the following conditions.

Condition                        Output

cars>people             We should take the cars

cars<people             We should not take the cars

cars==people           We can't decide

buses>cars              That's too many buses

buses<cars              Maybe we could take the buses

buses==people        We still can't decide

people>buses          All right let's just take the buses

people <= buses      Fine let's stay home then

 

Write a number value for:
1)people:
2)cars:
3)buses:
10
14
20
We should take the cars
That's too many buses
Fine let's stay home then
 */
namespace else_and_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number value for: \n1)people:\n2)cars:\n3)buses");
            Console.WriteLine(":");
            int people = int.Parse(Console.ReadLine());
            int cars = int.Parse(Console.ReadLine());
            int buses = int.Parse(Console.ReadLine());




            if (cars > people)
                Console.WriteLine("We should take the cars");
            else if (cars < people)
                Console.WriteLine("We should not take the cars");
            else
                Console.WriteLine("We can't decide");


            if (buses > cars)
                Console.WriteLine("That's too many buses");
            else if (buses < cars)
                Console.WriteLine("Maybe we could take the buses");



            if (people > buses)
                Console.WriteLine("All right let's just take the buses");
            else if (people <= buses)
            {

                if (people == buses)
                    Console.WriteLine("We still can't decide");


                Console.WriteLine(" Fine let's stay home then");
            }
            
        }
    }
}
