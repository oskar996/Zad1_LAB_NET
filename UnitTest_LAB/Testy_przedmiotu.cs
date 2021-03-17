using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zad1_LAB_NET;

namespace UnitTest_LAB
{
    [TestClass]
    public class Testy_Przedmiotu
    {
        [TestMethod]
        public void PoprawnoscWagi()
        {
            Przedmiot Prz = new Przedmiot();
            Prz.UstawWageIWartosc(10, 10);
            Assert.AreEqual(10, Prz.ZwrocWage());
        }

        [TestMethod]
        public void PoprawnoscWart()
        {
            Przedmiot Prz = new Przedmiot();
            Prz.UstawWageIWartosc(10, 10);
            Assert.AreEqual(10, Prz.ZwrocWartosc());
        }

    }
}
