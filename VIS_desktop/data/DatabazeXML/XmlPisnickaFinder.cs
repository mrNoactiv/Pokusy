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
    public class XmlPisnickaFinder : IPisnickaFinder
    {
        private string Path;
        public XmlPisnickaFinder()
        {
            Path = @"./../../../XML/IS.xml";
        }


        public Collection<IPisnickaGateway> SELECT()
        {
            List<IPisnickaGateway> list =
                new List<IPisnickaGateway>((
                    from ee in XDocument.Load(Path).Root.Elements("pisnicka")
                    select new XmlPisnickaGateway()
                    {
                        Id = (int) ee.Element("id"),
                        Nazev = (string) ee.Element("nazev"),
                        

                    }).ToList());

            Collection<IPisnickaGateway> gateway = new Collection<IPisnickaGateway>(list);
            return gateway;
        }

        public IPisnickaGateway SelectId(int id)
        {
            Collection<IPisnickaGateway> kolekceGateway = new Collection<IPisnickaGateway>();

            /*
            XElement xelement = XElement.Load(Path);
            var homePhone = from phoneno in xelement.Elements("pisnicka")
                            where (string)phoneno.Element("id") == id.ToString()
                            select phoneno;
            foreach (XElement xEle in homePhone)
            {
                IPisnickaGateway zg = new XmlPisnickaGateway();




                zg.Id = Int32.Parse(xEle.Element("id").Value);
                zg.Nazev = xEle.Element("nazev").Value;
                zg.Delka = xEle.Element("delka").Value;
                zg.Hodnoceni = float.Parse(xEle.Element("hodnoceni").Value);

                zg.Interpret.UmeleckeJmeno = xEle.
                zg.Album.Nazev = xEle.Element("nazevA").Value;
                zg.Nazev = xEle.Element("nazevZ").Value;


                kolekceGateway.Add(zg);
            }*/
            XDocument xmlDoc=XDocument.Load(Path);

            var objectList = xmlDoc.Descendants("pisnicka")
                    .Select(item => item);

            foreach (XElement item in objectList)
            {
                IPisnickaGateway zg = new XmlPisnickaGateway();
                zg.Id = Int32.Parse(item.Element("id").Value);
                zg.Nazev = item.Element("nazev").Value;
                zg.Delka = item.Element("delka").Value;
                zg.Hodnoceni = float.Parse(item.Element("hodnoceni").Value);

                var results = item.Descendants("album").Select(result => result);

                foreach (XElement result in results)
                {
                    IAlbumGateway ag = new XmlAlbumGateway();
                    ag.Nazev= result.Element("nazev").Value;

                    zg.Album = ag;
                }

                var resultsZanr = item.Descendants("zanr").Select(result => result);

                foreach (XElement result in resultsZanr)
                {
                    IZanrGateway zanrg=new XmlZanrGateway();

                    zanrg.Nazev= result.Element("nazev").Value;
                    zg.Zanr = zanrg;
                }

                var resultsInterpret = item.Descendants("interpret").Select(result => result);

                foreach (XElement result in resultsInterpret)
                {
                    IInterpretGateway ig=new XmlInterpretGateway();
                    ig.UmeleckeJmeno= result.Element("umeleckeJmeno").Value;

                    zg.Interpret = ig;
                }

                kolekceGateway.Add(zg);

            }




            IPisnickaGateway polozka = new XmlPisnickaGateway();
            if (kolekceGateway.Count == 1)
            {
                polozka = kolekceGateway[0];
            }
            return polozka;
        }

        public Collection<IPisnickaGateway> selectPodleAlba(string nazev)
        {
            throw new NotImplementedException();
        }

        public Collection<IPisnickaGateway> selectZanr(int id)
        {
            throw new NotImplementedException();
        }

        public void UpravHodnoceni(int id)
        {
            throw new NotImplementedException();
        }
    }
}
