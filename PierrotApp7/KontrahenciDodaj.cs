using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PierrotApp7;
using NIP24;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace PierrotApp7
{
    public partial class KontrahenciDodaj : Form
    {

        public static string nazwa;
        public static string WynikA;  // To jest pełny String Komunikatu

        public static string Regon;

        public static string Nip;

        public static string Nazwa;

        public static string Wojewodztwo;

        public static string Powiat;

        public static string Gmina;

        public static string Miejscowosc;

        public static string KodPocztowy;

        public static string Ulica;

        public static string NrNieruchomosci;

        public static string NrLokalu;

        public static string Typ;

        public static string DataZakonczeniaDzialalosci;

        public static string MiejscowoscPoczty;



        public KontrahenciDodaj()
        {
            InitializeComponent();
        }


        public class UpdateEventArgs: EventArgs
        {
            public string Data { get; set; }
        }


        private void kontrahenciBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.kontrahenciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
            this.Close();
        }

        private void KontrahenciDodaj_Load(object sender, EventArgs e)
        {

            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet.Kontrahenci' . Możesz go przenieść lub usunąć.
            this.kontrahenciTableAdapter.Fill(this.database1DataSet.Kontrahenci);
            bindingNavigatorAddNewItem.PerformClick();


            Form2 f2 = new Form2();
            f2.ShowDialog();
        }


        private void KontrahenciDodaj_Leave(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet.Kontrahenci' . Możesz go przenieść lub usunąć.
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlowneStatyczneMetody.PolaczBIR(nIPTextBox.Text);
           // PolaczBIR();

        }

        private void KontrahenciDodaj_Activated(object sender, EventArgs e)
        {
            textBox1.Text = Nazwa;
            rEGONTextBox.Text = Regon;
            nIPTextBox.Text = Nip;
            miastoTextBox.Text = Miejscowosc;
            wojewodztwoTextBox.Text = Wojewodztwo;
            powiatTextBox.Text = Powiat;
            kodTextBox.Text = KodPocztowy;
            ulicaTextBox.Text = Ulica;
            textBox3.Text = NrNieruchomosci;
            textBox2.Text = NrLokalu;


        }

        private void KontrahenciDodaj_Shown(object sender, EventArgs e)
        {

            textBox1.Text = Nazwa;
            rEGONTextBox.Text = Regon;
            nIPTextBox.Text = Nip;
            miastoTextBox.Text = Miejscowosc;
            wojewodztwoTextBox.Text = Wojewodztwo;
            powiatTextBox.Text = Powiat;
            kodTextBox.Text = KodPocztowy;
            ulicaTextBox.Text = Ulica;
            textBox3.Text = NrNieruchomosci;
            textBox2.Text = NrLokalu;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void KontrahenciDodaj_Click(object sender, EventArgs e)
        {

            textBox1.Text = Nazwa;
            rEGONTextBox.Text = Regon;
            nIPTextBox.Text = Nip;
            miastoTextBox.Text = Miejscowosc;
            wojewodztwoTextBox.Text = Wojewodztwo;
            powiatTextBox.Text = Powiat;
            kodTextBox.Text = KodPocztowy;
            ulicaTextBox.Text = Ulica;
            textBox3.Text = NrNieruchomosci;
            textBox2.Text = NrLokalu;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            textBox1.Text = Nazwa;
            rEGONTextBox.Text = Regon;
            nIPTextBox.Text = Nip;
            miastoTextBox.Text = Miejscowosc;
            wojewodztwoTextBox.Text = Wojewodztwo;
            powiatTextBox.Text = Powiat;
            kodTextBox.Text = KodPocztowy;
            ulicaTextBox.Text = Ulica;
            textBox3.Text = NrNieruchomosci;
            textBox2.Text = NrLokalu;
        }

        private void nIPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int a = GlowneStatyczneMetody.PolaczBIR(nIPTextBox.Text);

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
        }
    }
}
