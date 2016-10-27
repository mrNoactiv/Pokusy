using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Interface;
namespace VIS_desktop.Databaze
{
    public class Zanr
    {
        private IZanrGateway data;

        public Zanr(IZanrGateway data)
        {
            this.data = data;
        }

        public int Id
        {
            get { return this.data.Id; }
        }
        public String Nazev
        {
            get { return this.data.Nazev; }
            set { this.data.Nazev = Nazev; }
        }
        public String Popis
        {
            get { return this.data.Popis; }
            set { this.data.Popis = Popis; }
        }


    }
}
