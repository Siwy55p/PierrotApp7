using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PierrotApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = GlowneStatyczneMetody.PolaczBIR(NIP.Text);

            switch (a)
            {
                case 4:
                    Form3.Komunikat = a + " Nie znaleziono wpisu dla podanych kryteriów wyszukiwania." + KontrahenciDodaj.WynikA;
                    break;
                case 5:
                    Form3.Komunikat = a + " Nieprawidłowa lub pusta nazwa raportu. " + KontrahenciDodaj.WynikA;
                    break;
                case 11:
                    Form3.Komunikat = a + " Dla podmiotów skreślonych przed 2014-11-08 działalności PKD nie są udostępniane." + KontrahenciDodaj.WynikA;
                    break;
                case 21:
                    Form3.Komunikat = a + " Podmiot nie jest spółką cywilną " + KontrahenciDodaj.WynikA;
                    break;
                case 22:
                    Form3.Komunikat = a + " W rejestrze REGON brak jest wprowadzonych wspolników dla tej SC " + KontrahenciDodaj.WynikA;
                    break;
                default:
                    Form3.Komunikat = a + " Pobrano dane z GUS" + KontrahenciDodaj.WynikA;
                    break;
            }

            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
