using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PierrotApp7
{
    class GlowneStatyczneMetody
    {

        static public int PolaczBIR(string NIP)
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
                objParametrtyGR1.Nip = NIP;

                KontrahenciDodaj.WynikA += cc.DaneSzukajPodmioty(objParametrtyGR1);

                cc.Wyloguj(strSID);

            }
            cc.Close();

            //string xml = Wynik.Text;


            string xml = KontrahenciDodaj.WynikA;


            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            string ErrorCode = "1";

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



    }
}
