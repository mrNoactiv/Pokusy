using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;
using VIS_desktop.Interface;
namespace VIS_desktop.DatabazeXML
{
    public class XmlZanrGateway : IZanrGateway
    {
        private string Path;
        public XmlZanrGateway()
        {
            Path = @"./../../../XML/IS.xml";
        }



        public int Id
        { set; get; }
        public string Nazev
        { set; get; }
        public string Popis
        { set; get; }


        public int Insert()
        {
            throw new NotImplementedException();
        }

        public int Update()
        {
            throw new NotImplementedException();
        }
    }
}
