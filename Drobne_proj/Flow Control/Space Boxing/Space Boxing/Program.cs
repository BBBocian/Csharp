using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Julio Cesar Chavez Mark VII is an interplanetary space boxer, who currently holds the championship belts for various weight categories on many different planets within our solar system. However, it is often difficult for him to recall what his "target weight" needs to be on earth in order to make the weight class on other planets. Write a program to help him keep track of this.

It should ask him what his earth weight is, and to enter a number for the planet he wants to fight on. It should then compute his weight on the destination planet based on the table below:

#	Planet	Relative gravity
1	Venus	0.78
2	Mars	0.39
3	Jupiter	2.65
4	Saturn	1.17
5	Uranus	1.05
6	Neptune	1.23
So, for example, if Julio weighs 128 lbs. on earth, then he would weigh just under 50 lbs. on Mars, since Mars' gravity is 0.39 times earth's gravity. (128 * 0.39 is 49.92)

Input :
80
1
Output:
62.4
 * */

namespace Space_Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your current earth weight: ");
            float EWeight = float.Parse(Console.ReadLine());

            Console.WriteLine("I have information for the following planets:\n1.Venus 2.Mars 3.Jupiter 4.Saturn 5.Uranus 6.Neptune. So Which Planet You are Visiting ? :");
            int Planet = int.Parse(Console.ReadLine());
            ///Write your code here

            double[] tab = new double[] { 0.78, 0.39, 2.65, 1.17, 1.05, 1.23 };

            Console.WriteLine(EWeight * tab[Planet - 1]);
        }
    }
}
