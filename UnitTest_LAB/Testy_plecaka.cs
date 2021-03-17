using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zad1_LAB_NET;


namespace UnitTest_LAB
{
    [TestClass]
    public class Testy_Plecaka
    {

        [TestMethod]
        public void TestCzyWejdzieP()
        {
            Plecak Pl = new Plecak();
            Pl.UstawMaxWage(10);
            Przedmiot Pr = new Przedmiot();
            Pr.UstawWageIWartosc(1, 1);
            Assert.IsTrue(Pl.CzyWejdzie(Pr));

        }

        [TestMethod]
        public void TestCzyWejdzieF()
        {
            Plecak Pl = new Plecak();
            Pl.UstawMaxWage(10);
            Przedmiot Pr = new Przedmiot();
            Pr.UstawWageIWartosc(100, 100);
            Assert.IsFalse(Pl.CzyWejdzie(Pr));
        }

        [TestMethod]
        public void MaxWaga()
        {
            Plecak Pl = new Plecak();
            Pl.UstawMaxWage(10);

            Assert.AreEqual(10, Pl.PokazMaxWage());
        }
        
        [TestMethod]
        public void Czy_jesli_pusty_to_zero()
        {
            Plecak Pl = new Plecak();
            Pl.UstawMaxWage(10);
            Assert.AreEqual(0,Pl.PokazWartosc());
        }

        [TestMethod]
        public void TestDodajPrzedmiot()
        {
            Plecak Pl = new Plecak();
            Pl.UstawMaxWage(100);
            Przedmiot Prz = new Przedmiot();
            Prz.UstawWageIWartosc(10, 10);
            Pl.DodajPrzedmiot(Prz);

            Assert.AreEqual(10, Pl.PokazWage());
        }

        [TestMethod]
        public void TestDodajPrzedmiot2()
        {
            Plecak Pl = new Plecak();
            Pl.UstawMaxWage(100);
            Przedmiot Prz = new Przedmiot();
            Prz.UstawWageIWartosc(10, 10);
            Pl.DodajPrzedmiot(Prz);

            Assert.AreEqual(10, Pl.PokazWartosc());
        }
    }
}
