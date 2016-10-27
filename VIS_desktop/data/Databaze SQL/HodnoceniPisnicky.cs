using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Interface;

namespace VIS_desktop.Databaze
{
    public class HodnoceniPisnicky
    {

        private IHodnoceniPisnickyGateway data;

        public HodnoceniPisnicky(IHodnoceniPisnickyGateway data)
        {
            this.data = data;
        }

        public string Text
        {
            get
            {
                return this.data.Text;
            }
            set
            {
                this.data.Text=Text;
            }
        }

        public int Hodnoceni
        {
            get
            {
                return this.data.Hodnoceni;
            }
            set
            {
                this.data.Hodnoceni=Hodnoceni;
            }
        }

        public String Uzivatel
        {
            get
            {
                return this.data.Uzivatel.Prezdivka;
            }
        }

    }
}
