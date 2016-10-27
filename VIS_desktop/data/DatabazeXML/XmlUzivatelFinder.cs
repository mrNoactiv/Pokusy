using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VIS_desktop.Databaze;
using VIS_desktop.Interface;

namespace VIS_desktop.DatabazeXML
{
    public class XmlUzivatelFinder : Interface.IUzivatelFinder
    {
        private string Path;
        public XmlUzivatelFinder()
        {
            Path = @"./../../../XML/IS.xml";
        }



        public IUzivatelGateway login(string prezdivka, string heslo)
        {
            Collection<IUzivatelGateway> kolekceGateway = new Collection<IUzivatelGateway>();
            XElement xelement = XElement.Load(Path);
            var dotaz = from phoneno in xelement.Elements("uzivatel")
                            where (string)phoneno.Element("prezdivka") == prezdivka
                            && (string)phoneno.Element("heslo")==heslo
                            select phoneno;
            foreach (XElement xEle in dotaz)
            {
                IUzivatelGateway zg = new XmlUzivatelGateway();

                zg.Id = Int32.Parse(xEle.Element("id").Value);
                zg.Prezdivka = xEle.Element("prezdivka").Value;
                zg.Email = xEle.Element("email").Value;
                zg.Typ = xEle.Element("typ").Value;
                zg.Heslo = xEle.Element("heslo").Value;
                kolekceGateway.Add(zg);
            }
            IUzivatelGateway polozka = new XmlUzivatelGateway();
            if (kolekceGateway.Count == 1)
            {
                polozka = kolekceGateway[0];
                return polozka;
            }
            else
                return null;   
        }

        public IUzivatelGateway SelectId(int id)
        {
            Collection<IUzivatelGateway> kolekceGateway = new Collection<IUzivatelGateway>();
            XElement xelement = XElement.Load(Path);
            var dotaz = from phoneno in xelement.Elements("uzivatel")
                            where (string)phoneno.Element("id") == id.ToString()
                            select phoneno;
            foreach (XElement xEle in dotaz)
            {
                IUzivatelGateway zg = new XmlUzivatelGateway();

                zg.Id = Int32.Parse(xEle.Element("id").Value);
                zg.Prezdivka = xEle.Element("prezdivka").Value;
                zg.Email = xEle.Element("email").Value;
                zg.Typ = xEle.Element("typ").Value;
                zg.Heslo = xEle.Element("heslo").Value;
                kolekceGateway.Add(zg);
            }
            IUzivatelGateway polozka = new XmlUzivatelGateway();
            if (kolekceGateway.Count == 1)
            {
                polozka = kolekceGateway[0];
            }
            return polozka;
        }

        
    }
}
