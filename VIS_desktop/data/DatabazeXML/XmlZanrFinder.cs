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
    public class XmlZanrFinder : IZanrFinder
    {
        private string Path;
        public XmlZanrFinder()
        {
            Path = @"./../../../XML/IS.xml";
        }


        public Collection<IZanrGateway> SELECT()
        {
            List<IZanrGateway> list =
              new List<IZanrGateway>((
                  from ee in XDocument.Load(Path).Root.Elements("zanr")
                  select new XmlZanrGateway
                  {
                      Id = (int)ee.Element("id"),
                      Nazev = (string)ee.Element("nazev"),
                      Popis = (string)ee.Element("popis"),

                  }).ToList());

            Collection<IZanrGateway> gateway = new Collection<IZanrGateway>(list);
            return gateway;
        }

        public IZanrGateway SelectId(int id)
        {
            Collection<IZanrGateway> kolekceGateway = new Collection<IZanrGateway>();
            XElement xelement = XElement.Load(Path);
            var homePhone = from phoneno in xelement.Elements("zanr")
                            where (string)phoneno.Element("id") == id.ToString()
                            select phoneno;
            foreach (XElement xEle in homePhone)
            {
                IZanrGateway zg = new XmlZanrGateway();

                zg.Id = Int32.Parse(xEle.Element("id").Value);
                zg.Nazev = xEle.Element("nazev").Value;
                zg.Popis = xEle.Element("popis").Value;





                kolekceGateway.Add(zg);
            }
            IZanrGateway polozka = new XmlZanrGateway();
            if (kolekceGateway.Count == 1)
            {
                polozka = kolekceGateway[0];
            }
            return polozka;
        }
    }
    }

