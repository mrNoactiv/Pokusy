using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;
using VIS_desktop.Interface;

namespace VIS_desktop.DatabazeXML
{
    public class XmlPisnickaGateway : Interface.IPisnickaGateway
    {
        private string Path;
        public XmlPisnickaGateway()
        {
            Path = @"./../../../XML/IS.xml";
        }

        public int Id
        { set; get; }
        public string Nazev
        { set; get; }
        public string Delka
        { set; get; }
        public float Hodnoceni
        { set; get; }

        public IInterpretGateway Interpret
        { set; get; }
        public IAlbumGateway Album
        { set; get; }
        public IZanrGateway Zanr
        { set; get; }


        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

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
