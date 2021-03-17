using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zad1_LAB_NET;
using GeneratorCS;

namespace Łokienko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Plecak Plec = new Plecak();
            int Seed = 1;
            int MaxWaga = 10;

            Seed = int.Parse(textBox1.Text);
            MaxWaga = int.Parse(textBox2.Text);

            RandomNumberGenerator x = new RandomNumberGenerator(Seed);

            Przedmiot Pom = new Przedmiot();

            Plec.UstawMaxWage(MaxWaga);

            for (int i = 0; i < 10; i++)
            {

                Pom.UstawWageIWartosc(x.nextInt(1, 30), x.nextInt(1, 30));

                if (Plec.CzyWejdzie(Pom))
                {
                    Plec.DodajPrzedmiot(Pom);
                    listBox1.Items.Add(" Przedmiot o wadze " + Pom.ZwrocWage() + " i wartosci " + Pom.ZwrocWartosc() + " zmiescil sie \n");
                }
                else
                {
                    listBox1.Items.Add(" Przedmiot o wadze " + Pom.ZwrocWage() + " i wartosci " + Pom.ZwrocWartosc() + " nie zmiescil sie \n");
                }
            }
            listBox1.Items.Add("Suma wagi przedmiotow: " + Plec.PokazWage() + "\n");
            listBox1.Items.Add("Suma wartosci przedmiotow: " + Plec.PokazWartosc() + "\n");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
