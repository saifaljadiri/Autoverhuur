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
            double kilometerprijsauto =0.2;
            double autotank = 40;
            double beinzineprijs = 1.645;
            

            



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double y = 0.3;
            int x = 1;


            Console.WriteLine(x * y);
        
            

        }
    }
}

// variabele totaalKostenAuto (double)
// variabele totaalKostenBusje (double)

// variabele beginDatum (dateTime)
// variabele eindDatum (dateTime)
// variabele aantalKilometersGereden (integer van textBox)
// variabele maxTankBenzine (integer van 80)
// variabele verbruikKosten
// variabele benzinePrijs (double van 1.645)
// variabele kilometerprijsBus (double van 0.3)
// variabele kilometerprijsAuto (double van 0.2)
// variabele dagtariefBus (double van 95)

// bereken kosten verbruikte benzine
    // aantalKilometersGereden / verbruikKosten * benzinePrijs

// bereken kosten geredenAfstand
    // if (isPersonenAuto)
    // {
        // if (aantalKilometersGereden > 100)
        // {
            // aantalKilometersGereden - 100 * kilomtertariefAuto
        // }
        // else
        // {
            // return 0;
        // }
    // }
    // else
    // {
        // aantalKilometersGereden * kilometertariefBusje
    // }

// bereken kosten huurPeriode
    // dateTime aantalGeredenDagen = eindTijd - beginTijd
    // aantalGeredenDagen * dagtariefBus

// totaalKostenBusje = berekenKostenVerbruikBenzine + berekenKostenGeredenAfstand + berekenKostenHuurPeriode
