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

namespace PierrotApp7
{
    public partial class KontrahenciDodaj : Form
    {

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

            Wynik.Text = "### Zaloguj: ";

            using (OperationContextScope scope = new OperationContextScope(cc.InnerChannel))
            {
                HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                requestMessage.Headers.Add("sid", strSID);
                OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;

                ServiceReference1DEMO.ParametryWyszukiwania objParametrtyGR1 = new ServiceReference1DEMO.ParametryWyszukiwania();
                objParametrtyGR1.Nip = NIP.Text;
                Wynik.Text += cc.DaneSzukajPodmioty(objParametrtyGR1);
                Wynik.Text += cc.DanePobierzPelnyRaport(rEGONTextBox.Text, "PublDaneRaportPrawna");
                cc.Wyloguj(strSID);

                Wynik.Text += cc.GetValue("KomunikatKod");
                Wynik.Text += cc.GetValue("KomunikatTresc");
                Wynik.Text += cc.GetValue("StatusSesji");

            }

            cc.Close();

        }

        //        sid=Zaloguj(); do {
        //DaneSzukajPodmioty(regon lub nip lub krs); 
        //i/lub DanePobierzPelnyRaport(regon, nazwaRaportu);
        //i/lub DanePobierzRaportZbiorczy(data, nazwaRaportu); 
        //if(pusta odpowiedz) => sprawdź przyczynę metodą diagnostyczną GetValue() - str. 11.
        //if (sesja wygasla) => sid=Zaloguj();
        //    } while(…);
        //Wyloguj(sid); // pusta odpowiedz to: <DaneSzukajPodmiotyResult/> lub 
        //<DanePobierzPelnyRaportResult/> lub <DanePobierzRaportZbiorczyResult/>



        // Utworzenie obiektu klienta usługi serwisu produkcyjnego
        // id – ciąg znaków reprezentujący identyfikator klucza API
        // key – ciąg znaków reprezentujący klucz API
        NIP24Client nip24 = new NIP24Client("RjnuwYcuNPZE", "0uooI8SjdHUS");

        public AllData SzczegoloweDaneFirmy(string NIP)
        {
            // Wywołanie metody zwracającej szczegółowe dane firmy
            AllData all = nip24.GetAllData(Number.NIP, NIP);
            string a ="";
            if (all != null)
            {
                nazwa_kontrahentaTextBox.Text = all.Name;
                miastoTextBox.Text = all.City;
                nIPTextBox.Text = NIP;
                kodTextBox.Text = all.PostCity;
                ulicaTextBox.Text = all.Street;
                krajTextBox.Text = all.County;
                wojewodztwoTextBox.Text = all.Community;
                powiatTextBox.Text = all.State;
                rEGONTextBox.Text = all.REGON;

                return all;
            }
            else
            {
                return all;
            }
        }


        public string SprawdzenieStatusuFirmy(string NIP)
        {
            string a = "";
           // Sprawdzenie statusu firmy wartosc: "123-456-78-90"
            bool active = nip24.IsActive(Number.NIP, NIP);

            

            if (active)
            {
                a = "Firma prowadzi aktywną działalność";
                return a;
            }
            else
            {
                if (String.IsNullOrEmpty(nip24.LastError))
                {
                    a = "Firma zawiesiła lub zakończyła działalność";
                    return a;
                }
                else
                {
                    a = "Błąd" + nip24.LastError;
                    return a;
                }
            }
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
    }
}
