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

        public int PolaczBIR()
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


            using (OperationContextScope scope = new OperationContextScope(cc.InnerChannel))
            {
                HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                requestMessage.Headers.Add("sid", strSID);
                OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;

                ServiceReference1DEMO.ParametryWyszukiwania objParametrtyGR1 = new ServiceReference1DEMO.ParametryWyszukiwania();
                objParametrtyGR1.Nip = NIP.Text;

                KontrahenciDodaj.WynikA += cc.DaneSzukajPodmioty(objParametrtyGR1);
                
                cc.Wyloguj(strSID);

            }
            cc.Close();

            //string xml = Wynik.Text;

            richTextBox1.Text = KontrahenciDodaj.WynikA;

            string xml = KontrahenciDodaj.WynikA;

            richTextBox1.Text = xml;

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            string ErrorCode ="1";

            try
            {
                KontrahenciDodaj.Nazwa = doc["root"]["dane"]["Nazwa"].InnerText;
                KontrahenciDodaj.Regon = doc["root"]["dane"]["Regon"].InnerText;
                KontrahenciDodaj.Nip = doc["root"]["dane"]["Nip"].InnerText;
                KontrahenciDodaj.Wojewodztwo = doc["root"]["dane"]["Wojewodztwo"].InnerText;
                KontrahenciDodaj.Powiat = doc["root"]["dane"]["Powiat"].InnerText;
                KontrahenciDodaj.Gmina = doc["root"]["dane"]["Gmina"].InnerText;
                KontrahenciDodaj.Miejscowosc = doc["root"]["dane"]["Miejscowosc"].InnerText;
                KontrahenciDodaj.KodPocztowy = doc["root"]["dane"]["KodPocztowy"].InnerText;
                KontrahenciDodaj.Ulica = doc["root"]["dane"]["Ulica"].InnerText;
                KontrahenciDodaj.NrNieruchomosci = doc["root"]["dane"]["NrNieruchomosci"].InnerText;
                KontrahenciDodaj.NrLokalu = doc["root"]["dane"]["NrLokalu"].InnerText;
                KontrahenciDodaj.Typ = doc["root"]["dane"]["Typ"].InnerText;
                //  KontrahenciDodaj.DataZakonczeniaDzialalosci = doc["root"]["dane"]["DataZakonczeniaDzialalosci"].InnerText;
                KontrahenciDodaj.MiejscowoscPoczty = doc["root"]["dane"]["MiejscowoscPoczty"].InnerText;
            }
            catch
            {
                ErrorCode = "4";

            }


            try
            {



                ErrorCode = doc["root"]["dane"]["ErrorCode"].InnerText;
            }
            catch
            {

            }
            KontrahenciDodaj.WynikA = "";

            return Int32.Parse(ErrorCode);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = PolaczBIR();

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
