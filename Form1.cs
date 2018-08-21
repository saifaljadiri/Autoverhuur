using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoverhuur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar2.MaxSelectionCount = 1;
        }
        DateTime OphaalDatum;
        DateTime TerugbrengDatum;

        double aantalKmAuto = 0;
        double personenAutoVerbruikPerKm = 0.2;
        double personenAutoPerDag = 50;
        double benzinePrijs = 1.64;
        double personenAutoVerbruik = 19;

        double aantalKmBusje = 0;
        double personenBusjeVerbruikPerKm = 0.3;
        double personenBusjePerDag = 95;
        double dieselPrijs = 1.35;
        double personenBusjeVerbruik = 15;

        double benzineVerbruik;
        double dieselVerbruik;

        public int CalculateAge1(DateTime birthDate, DateTime now)
        {
            return new DateTime(now.Subtract(birthDate).Ticks).Year - 1;
        }

        public int CalculateAge2(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;

            if (now < birthDate.AddYears(age))
                age--;

            return age;
        }



        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aantalKmAuto = Convert.ToDouble(textBox1.Text);
            aantalKmBusje = Convert.ToDouble(textBox2.Text);

            aantalKmAuto -= 100;
            if (aantalKmAuto > 0) // boven 100 km
            {
                benzineVerbruik = aantalKmAuto / personenAutoVerbruik * benzinePrijs + aantalKmAuto * personenAutoVerbruikPerKm;
            }
            else // onder 100 km
            {
                benzineVerbruik = 0;
            }

            dieselVerbruik = aantalKmBusje / personenBusjeVerbruik * dieselPrijs + aantalKmBusje * personenBusjeVerbruikPerKm;

            OphaalDatum = monthCalendar1.SelectionRange.Start.Date;
            TerugbrengDatum = monthCalendar2.SelectionRange.Start.Date;
            int aantalGeredenDagen = 0;

            if (OphaalDatum == TerugbrengDatum)
            {
                aantalGeredenDagen = 1;
            }
            else
            {
                aantalGeredenDagen = TerugbrengDatum.DayOfYear - OphaalDatum.DayOfYear;
            }
           
            double aantalGeredenDagenKostenBus = aantalGeredenDagen * personenBusjePerDag;
            double aantalGeredenDagenKostenAuto = aantalGeredenDagen * personenAutoPerDag;


            
            double totaalKostenBus = dieselVerbruik + aantalGeredenDagenKostenBus;
            double totaalKostenAuto = benzineVerbruik + aantalGeredenDagenKostenAuto;

            textBox3.Text = Convert.ToString(totaalKostenAuto);
            textBox4.Text = Convert.ToString(totaalKostenBus);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}

