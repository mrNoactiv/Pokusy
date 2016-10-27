using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VIS_desktop.Databaze;
using VIS_desktop.Interface;
namespace VIS_desktop.DatabazeXML
{
    public class XmlUzivatelGateway : IUzivatelGateway
    {
        private string Path;
        public XmlUzivatelGateway()
        {
            Path = @"./../../../XML/IS.xml";
        }



        public int Id
        { get; set; }
        public string Prezdivka
        { set; get; }

        public string Heslo
        { set; get; }

        public string Email
        { set; get; }
        public string Typ
        { set; get; }


        public int Insert()
        {
            XElement xEle = XElement.Load(Path);
            xEle.Add(new XElement("uzivatel",
                new XElement("id", 5421),
                new XElement("prezdivka", this.Prezdivka),
                new XElement("typ", this.Typ),
                new XElement("heslo", this.Heslo)

                )

                );

            Console.Write(xEle);

            xEle.Save(Path);

            return 1;
        }

        public int Update()
        {
            XDocument doc = XDocument.Load(Path);


            var iuzivatel = from hue in doc.Descendants("uzivatel")
                where (string) hue.Element("id") == Id.ToString()
                select hue;

                foreach (XElement itemElement in iuzivatel)
                {
                    itemElement.SetElementValue("prezdivka", this.Prezdivka);
                    itemElement.SetElementValue("email", this.Email);
                    itemElement.SetElementValue("heslo", this.Heslo);
            }

                doc.Save(Path);
            /*
            var userUpdateEmail = from phoneno in xEle.Elements("uzivatel").Elements("email")
                                      where (string)phoneno.Element("id") == Id.ToString()
                                      select phoneno;

            foreach (XElement cEle in userUpdateEmail)
                cEle.ReplaceNodes(this.Email);

            var userUpdateHeslo = from phoneno in xEle.Elements("uzivatel").Elements("heslo")
                                  where (string)phoneno.Element("id") == Id.ToString()
                                  select phoneno;

            foreach (XElement cEle in userUpdateHeslo)
                cEle.ReplaceNodes(this.Heslo);*/


            Console.Write(doc);
            return 1;
        }
    }
}
