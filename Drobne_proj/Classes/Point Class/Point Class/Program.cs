using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt();
            Punkt p2 = new Punkt(20, 40);

            Kolor kolor = new Kolor(20, 30, 100);

            
            
            Console.WriteLine(kolor.getX()+" "+kolor.getY()+" "+kolor.pobierzKolor());

            kolor.UstawX(200);

            Console.WriteLine(kolor.getX() + " " + kolor.getY() + " " + kolor.pobierzKolor());

            Console.ReadLine();
        }
    }
}
