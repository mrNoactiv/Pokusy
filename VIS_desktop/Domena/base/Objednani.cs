using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Interface;

namespace VIS_desktop.Databaze
{
    public class Objednani
    {
        IObjednaniGateway data;

        public Objednani (IObjednaniGateway data)
        {
            this.data = data;
        }

        public int Pisnicka
        {
            get { return this.data.Pisnicka.Id; }
            set { this.data.Pisnicka.Id = value; }
        }

        public int Objednavka
        {
            get { return this.data.Objednavka.Id; }
            set { this.data.Objednavka.Id = value; }
        }
        public String Email
        {
            get { return this.data.Objednavka.Uzivatel.Email; }
            set { this.data.Objednavka.Uzivatel.Email = value; }

        }
        public int Uzivatel
        {
            get { return this.data.Objednavka.Uzivatel.Id; }
            set { this.data.Objednavka.Uzivatel.Id = value; }
        }


    }
}
