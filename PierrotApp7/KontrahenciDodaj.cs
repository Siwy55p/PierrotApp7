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
        public static string WynikA;

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

        public void PolaczBIR()
        {
            // Create a WSHttpBinding and set its property values.
            WSHttpBinding myBinding = new WSHttpBinding();

            myBinding.Security.Mode = SecurityMode.Transport;
            myBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            myBinding.MessageEncoding = WSMessageEncoding.Mtom;

            
            EndpointAddress ea = new EndpointAddress(
                        new Uri(@"https://wyszukiwarkaregontest.stat.gov.pl/wsBIR/UslugaBIRzewnPubl.svc")); //test

            ServiceReference1DEMO.UslugaBIRzewnPublClient cc = new ServiceReference1DEMO.UslugaBIRzewnPublClient(myBinding, ea);

            cc.Open();
            string strSID = cc.Zaloguj("abcde12345abcde12345");

            string xmla;

            using (OperationContextScope scope = new OperationContextScope(cc.InnerChannel))
            {
                HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                requestMessage.Headers.Add("sid", strSID);
                OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;

                ServiceReference1DEMO.ParametryWyszukiwania objParametrtyGR1 = new ServiceReference1DEMO.ParametryWyszukiwania();
                objParametrtyGR1.Nip = nIPTextBox.Text;
                Wynik.Text += cc.DaneSzukajPodmioty(objParametrtyGR1);
                //Wynik.Text += cc.DanePobierzPelnyRaport(rEGONTextBox.Text, "PublDaneRaportPrawna");

                xmla = cc.DanePobierzPelnyRaport(rEGONTextBox.Text, "PublDaneRaportPrawna");

                Wynik.Text += xmla;
                
                cc.Wyloguj(strSID);
                //Wynik.Text += cc.GetValue("KomunikatKod");
                //Wynik.Text += cc.GetValue("KomunikatTresc");
                //Wynik.Text += cc.GetValue("StatusSesji");


            }
            cc.Close();
            
            string xml = Wynik.Text;

            rEGONTextBox.Text = xml;


            //string xmlContent = "<foo></foo>";

            //XElement newNode = XDocument.Parse(xmla).Root;

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            //doc.LoadXml(xmla.ToString());

            rEGONTextBox.Text = doc["root"]["dane"]["Regon"].InnerText; //WILL RETURN "wrench"

            //Wynik.Text = doc["item"]["name"].InnerText; //WILL RETURN "wrench"


        }


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

            //bindingNavigatorAddNewItem.


            Form2 f2 = new Form2();
            //f2.Show();
            //f2.Focus();
            f2.ShowDialog();
            //Application.OpenForms[f2.Name].Focus();
            //f2.Activate();



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
            PolaczBIR();
            //string wynik = SprawdzenieStatusuFirmy(NIP.Text);
            //SzczegoloweDaneFirmy(NIP.Text);

            //Wynik.Text = wynik;
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
    }
}
