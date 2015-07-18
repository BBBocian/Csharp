using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Class
{
    class Punkt 
    {
        int x;
        int y;

        public Punkt()
        {
            x = 600;
            y = 800;
        }
        public Punkt(int wspx,int wspy)
        {
            x = wspx;
            y = wspy;
        }

        public void pobierzWsp(Punkt nazwa)
        {
            x = nazwa.x;
            y = nazwa.y;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void UstawX(int nowyX)
        {
            x = nowyX;
        }
        public void UstawY(int nowyY)
        {
            y = nowyY;
        }

    }
}
