using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Interface;

namespace VIS_desktop.Databaze
{
    public class Ulozeni
    {
        private IUlozeniGateway data;

        public Ulozeni(IUlozeniGateway data)
        {
            this.data = data;
        }


        public int IdPisnicky
        {
            get
            {
                return this.data.Pisnicka.Id;
            }
        }

        public String NazevPisnicky
        {
            get
            {
                return this.data.Pisnicka.Nazev;
            }
        }
        public int IdKnihovny
        {
            get
            {
                return this.data.Knihovna.Id;
            }
        }

        public int IdUzivatele
        {
            get
            {
                return this.data.Knihovna.Uzivatel.Id;
            }
        }


    }
}
