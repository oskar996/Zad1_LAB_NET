using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1_LAB_NET
{
    public class Plecak
    {
        int WagaPrzedmiotow = 0;
        int MaxWaga = 0;
        int Wartosc = 0;

        public Plecak()
        {

        }
        
        //pozwala dodać przedmiot do plecaka
        public void DodajPrzedmiot(Przedmiot Prz)
        {
            WagaPrzedmiotow = WagaPrzedmiotow + Prz.ZwrocWage();
            Wartosc = Wartosc + Prz.ZwrocWartosc();
        }
        //Funkcja sprawdzajaca czy kolejny przedmiot zmiesci sie w plecaku, jesli tak zwraca 1, w przeciwnym przypadku 0
        public bool CzyWejdzie(Przedmiot Prz)
        {
            if(WagaPrzedmiotow + Prz.ZwrocWage() <= MaxWaga)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //pozwala ustawic maksymalna wage plecaka
        public void UstawMaxWage(int Waga)
        {
            MaxWaga = Waga;
        }
        
        //pokazuje laczna wage przedmiotow w plecaku
        public int PokazWage()
        {
            return WagaPrzedmiotow;
        }
        
        //pokazje maksymalna wage jaka pomiesci plecak
        public int PokazMaxWage()
        {
            return MaxWaga;
        }
        
        //pokazuje laczna wartosc przedmiotow w plecaku
        public int PokazWartosc()
        {
            return Wartosc;
        }
    }

}
