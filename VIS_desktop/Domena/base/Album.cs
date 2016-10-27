using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.DatabazeXML;
using VIS_desktop.Interface;

namespace VIS_desktop.Databaze
{
    public class Album
    {
        private IAlbumGateway data;

        public Album(IAlbumGateway data)
        {
            this.data = data;
        }

        public string Nazev
        {
            get
            {
                return this.data.Nazev;
            }
            set {
                this.data.Nazev = value;
            }

        }

        public DateTime DatumVydani
        {
            get
            {
                return this.data.DatumVydani;
            }
            set
            {
                this.data.DatumVydani=value;
            }

        }

        public int Id
        {
            get
            {
                return this.data.Id;
            }
            set
            {
                this.data.Id = value;
            }
        }

    }
}
