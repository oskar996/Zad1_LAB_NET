using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorCS;

namespace Zad1_LAB_NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Plecak Plec = new Plecak();
            RandomNumberGenerator x = new RandomNumberGenerator(1);

            Przedmiot Pom = new Przedmiot();

            Plec.UstawMaxWage(50);

            for  (int i  =  0; i  <  10; i++) {
              
                Pom.UstawWageIWartosc(x.nextInt(1, 30), x.nextInt(1, 30));
                
                if (Plec.CzyWejdzie(Pom))
                {
                    Plec.DodajPrzedmiot(Pom);
                    System.Console.Write(" Przedmiot o wadze "+ Pom.ZwrocWage() + " i wartosci " + Pom.ZwrocWartosc() + " zmiescil sie \n");
                }
                else
                {
                    System.Console.Write(" Przedmiot o wadze "+ Pom.ZwrocWage() + " i wartosci " + Pom.ZwrocWartosc() + " nie zmiescil sie \n");
                }
            }
            System.Console.Write("Suma wagi przedmiotow: " + Plec.PokazWage() + "\n");
            System.Console.Write("Suma wartosci przedmiotow: " + Plec.PokazWartosc() + "\n");
            


            System.Console.ReadKey();
        }
    }
}
