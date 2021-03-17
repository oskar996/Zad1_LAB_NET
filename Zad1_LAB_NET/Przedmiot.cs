using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1_LAB_NET
{
    public class Przedmiot
    {
        int Waga = 0;
        int Wartosc = 0;


        public void UstawWageIWartosc(int Wag, int War)
        {
            Waga = Wag;
            Wartosc = War;
        }

        public int ZwrocWage()
        {
            return Waga;
        }

        public int ZwrocWartosc()
        {
            return Wartosc;
        }
    }

    

}