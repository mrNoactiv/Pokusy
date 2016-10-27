using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using VIS_desktop.Databaze;
using VIS_desktop.Interface;
namespace VIS_desktop.DatabazeXML
{
    public class XmlAlbumFinder : IAlbumFinder
    {

        private string Path;
        public XmlAlbumFinder()
        {
            Path = @"./../../../XML/IS.xml";
        }


        public Collection<IAlbumGateway> Select()
        {

            List<IAlbumGateway> albumList =
               new List<IAlbumGateway>((
                   from ee in XDocument.Load(Path).Root.Elements("album")
                   select new XmlAlbumGateway
                   {
                       Id = (int)ee.Element("id"),
                       Nazev = (string)ee.Element("nazev"),
                       PocetPisnicek = (int)ee.Element("pocetPisnicek"),
                       DatumVydani = (DateTime)ee.Element("datumVydani"),

                   }).ToList());
            
            Collection<IAlbumGateway> ag = new Collection<IAlbumGateway>(albumList);
            return ag;
        }

        public IAlbumGateway SelectId(int id)
        {
            

            Collection<IAlbumGateway> a = new Collection<IAlbumGateway>();
            XElement xelement = XElement.Load(@"./../../../XML/XML_sablona.xml");
            var homePhone = from phoneno in xelement.Elements("album")
                            where (string)phoneno.Element("id") == id.ToString()
                            select phoneno;
            foreach (XElement xEle in homePhone)
            {
                IAlbumGateway al = new AlbumGateway();
                DateTime datum = DateTime.Parse(xEle.Element("datumVydani").Value);

                al.Id = Int32.Parse(xEle.Element("id").Value);
                al.Nazev = xEle.Element("nazev").Value;
                al.PocetPisnicek = Int32.Parse(xEle.Element("pocetPisnicek").Value);
                al.DatumVydani = datum;

                a.Add(al);
            }
            IAlbumGateway album = new AlbumGateway();
            if (a.Count==1)
            {
                album = a[0];
            }
            return album;
        }
    }
}
