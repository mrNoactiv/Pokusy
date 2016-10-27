using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Interface;

namespace VIS_desktop.Databaze
{
    public class Knihovna
    {
        private IKnihovnaGateway data;

        public Knihovna(IKnihovnaGateway data)
        {
            this.data = data;
        }

        public int Id
        {
            get { return this.data.Id; }
            set { this.data.Id = value; }
        }

        public int Uzivatel
        {
            get { return this.data.Uzivatel.Id; }
            set { this.data.Uzivatel.Id = value; }
        }


    }
}
