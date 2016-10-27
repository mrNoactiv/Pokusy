using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using VIS_desktop.Databaze;
using VIS_desktop.Interface;

namespace VIS_desktop.DatabazeXML
{
    public class XmlAlbumGateway : IAlbumGateway
    {
        private string Path;
        public XmlAlbumGateway()
        {
            Path = @"./../../../XML/IS.xml";
        }

        

        public int Id
        { set; get; }
        public string Nazev
        { set; get; }
        public int PocetPisnicek
        { set; get; }
        public DateTime DatumVydani
        { set; get; }




        public int Insert()
        {
            /*last element pouzit na id
            XDocument doc = XDocument.Load("yourfile.xml");
            XElement root = doc.Root;
            Console.WriteLine(root.Elements("post").Last());
            */

            XElement xEle = XElement.Load(Path);
            xEle.Add(new XElement("album",
                new XElement("id", 5421),
                new XElement("nazev", this.Nazev),
                new XElement("pocetPisnicek", 0),
                new XElement("datumVydani", this.DatumVydani)

                )

                );

            Console.Write(xEle);

            xEle.Save(Path);

            return 1;
            
        }

        public int Delete()
        {
            throw new NotImplementedException();
        }
    }
}
