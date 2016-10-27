using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;
using VIS_desktop.DatabazeXML;
using VIS_desktop.Interface;

namespace VIS_desktop.Domenova
{
    public class UzivatelService
    {

        private IUzivatelFinder finder;

        public UzivatelService()
        {
            finder = new UzivatelFinder();
        }

        public Uzivatel getUzivatel(int param)
        {

            //UzivatelGateway uzivatelGateway = new UzivatelFinder().SelectId(param);
            IUzivatelGateway uzivatelGateway = finder.SelectId(param);
            Uzivatel uzivatel = new Uzivatel(uzivatelGateway);

            return uzivatel;

        }

        public void InsertUzivatel(Uzivatel uzivatel)
        {
            Uzivatel u = uzivatel;
            IUzivatelGateway ug = new UzivatelGateway();
            ug.Id = u.Id;
            ug.Prezdivka = u.Prezdivka;
            ug.Heslo = u.Heslo;
            ug.Typ = u.Typ;
            ug.Email = u.Email;
                

            ug.Insert();

        }

        public void UpdateUzivatel(Uzivatel uzivatel,int id)
        {
            Uzivatel u = uzivatel;
            IUzivatelGateway ug = new XmlUzivatelGateway();
            ug.Id = id;
            ug.Prezdivka = u.Prezdivka;
            ug.Heslo = u.Heslo;
            ug.Email = u.Email;
            ug.Typ = u.Typ;


            ug.Update();

        }

        public Uzivatel getLoginUzivatele(string prezdivka,string heslo)
        {
            //UzivatelGateway uzivatelGateway = new UzivatelFinder().login(prezdivka, heslo);
            IUzivatelGateway uzivatelGateway = finder.login(prezdivka, heslo);
            

            Uzivatel uzivatel = new Uzivatel(uzivatelGateway);

            return uzivatel;
        }


    }
}
