using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Class
{
    class Kolor : Punkt
    {
        private int kolor;

        public Kolor()
        {
            kolor = 100;
        }
        public Kolor(int wspx,int wspy, int kolor)  : base(wspx1,wspy)
        {
            
            UstawKolor(kolor);
            
        }
        public void UstawKolor(int nowy_kolor)
        {
            kolor=nowy_kolor;
        }
        public int pobierzKolor()
        {
            return kolor;
        }
    }
}
