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
    public class XmlInterpretFinder : Interface.IInterpretFinder
    {
        private string Path;
        public XmlInterpretFinder()
        {
            Path = @"./../../../XML/IS.xml";
        }


        public Collection<IInterpretGateway> SELECT()
        {
            List<IInterpretGateway> list =
               new List<IInterpretGateway>((
                   from ee in XDocument.Load(Path).Root.Elements("interpret")
                   select new XmlInterpretGateway
                   {
                       Id = (int)ee.Element("id"),
                       Jmeno = (string)ee.Element("jmeno"),
                       UmeleckeJmeno = (string)ee.Element("umeleckeJmeno"),
                       Zeme= (string)ee.Element("zeme"),
                       DatumNarozeni = (DateTime)ee.Element("datumNarozeni"),

                   }).ToList());

            Collection<IInterpretGateway> gateway = new Collection<IInterpretGateway>(list);
            return gateway;
        }

        public IInterpretGateway SelectId(int id)
        {
            Collection<IInterpretGateway> kolekceGateway = new Collection<IInterpretGateway>();
            XElement xelement = XElement.Load(Path);
            var dotaz = from phoneno in xelement.Elements("interpret")
                        where (string)phoneno.Element("id") == id.ToString()
                        select phoneno;
            foreach (XElement xEle in dotaz)
            {
                IInterpretGateway zg = new XmlInterpretGateway();

                DateTime datum = DateTime.Parse(xEle.Element("datumNarozeni").Value);

                zg.Id = Int32.Parse(xEle.Element("id").Value);
                zg.Jmeno = xEle.Element("jmeno").Value;
                zg.UmeleckeJmeno = xEle.Element("umeleckeJmeno").Value;
                zg.Zeme = xEle.Element("zeme").Value;
                zg.DatumNarozeni = datum;
                kolekceGateway.Add(zg);
            }
            IInterpretGateway polozka = new XmlInterpretGateway();
            if (kolekceGateway.Count == 1)
            {
                polozka = kolekceGateway[0];
            }
            return polozka;
        }
    }
}
