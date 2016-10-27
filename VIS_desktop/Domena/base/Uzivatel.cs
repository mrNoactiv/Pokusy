using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Interface;

namespace VIS_desktop.Databaze
{
    public class Uzivatel
    {
        private IUzivatelGateway data;

        public Uzivatel(IUzivatelGateway data)
        {
            this.data = data;
        }

        public int Id
        {
            get
            {
                return this.data.Id;
            }
        }


        public String Prezdivka
        {
            get
            {
                return this.data.Prezdivka;
            }
            set
            {
                this.data.Prezdivka = Prezdivka;
            }

        }

        public String Heslo
        {
            get
            {
                return this.data.Heslo;
            }
            set
            {
                this.data.Heslo = Heslo;
            }
        }


        public String Email
        {
            get
            {
                return this.data.Email;
            }
            set
            {
                this.data.Email = Email;
            }
        }
        public String Typ
        {
            get
            {
                return this.data.Typ;
            }
            set
            {
                this.data.Typ = Typ;
            }
        }

        public Boolean isAdministrator()
        {
            if (this.data.Typ == "user")
            {
                return false;
            }
            else
                return true;

        }
    }
}