using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*It should ask you what your earth weight is, and to enter a number for the planet you want to fight on. It should then compute your weight on the destination planet based on the table below:

#    Planet    Relative gravity
1    Venus     0.78
2    Mars       0.39
3    Jupiter    2.65
4    Saturn    1.17
5    Uranus   1.05
6    Neptune 1.23 

Please enter your current earth weight:128
I have information for the following planets:
1. Venus
2. Mars
3. Jupiter
4. Saturn
5. Uranus
6. Neptune
Which planet are you visiting?:2
Your weight would be 49.92 pounds on that planet.
 */

namespace Space_boxing_2
{
    class Program
    {
        static void Main(string[] args)   
        {
        int w, p;
        Console.Write("Please enter your current earth weight:");
        w = int.Parse(Console.ReadLine());
        Console.WriteLine("I have information for the following planets:");
        Console.WriteLine("1. Venus");
        Console.WriteLine("2. Mars");
        Console.WriteLine("3. Jupiter");
        Console.WriteLine("4. Saturn");
        Console.WriteLine("5. Uranus");
        Console.WriteLine("6. Neptune");
        Console.Write("Which planet are you visiting?:");
        p = int.Parse(Console.ReadLine());

        
        Dictionary<int,double> dict = new Dictionary<int,double>();
        // Dict(int number of planet, value)
        
        dict.Add(1,0.78);
        dict.Add(2,0.39);
        dict.Add(3,2.65);
        dict.Add(4,1.17);
        dict.Add(5,1.05);
        dict.Add(6,1.23);
           
        Console.WriteLine("Your weight would be {0} pounds on that planet.",w*dict[p]);

        }
    }
}
