using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VIS_desktop.Databaze;

namespace VIS_desktop.DatabazeXML
{
    public class XmlInterpretGateway : Interface.IInterpretGateway
    {
        private string Path;
        public XmlInterpretGateway()
        {
            Path = @"./../../../XML/IS.xml";
        }

        public int Id
        { get; set; }
        public string Jmeno
        { get; set; }
        public string UmeleckeJmeno
        {
            get; set;
        }
        public string Zeme
        { get; set; }
        public DateTime DatumNarozeni
        { get; set; }

        public int Delete(int id)
        {
            XDocument doc = XDocument.Load(Path);

            var interpret = from hue in doc.Descendants("interpret")
                            where (string)hue.Element("id") == id.ToString()
                            select hue;

                    interpret.Remove();

            doc.Save(Path);

            return 1;
        }

        public int Insert()
        {
            throw new NotImplementedException();
        }
    }
}
