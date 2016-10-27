using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;
using VIS_desktop.Interface;

namespace VIS_desktop.Domenova
{
    public class ObjednavkaService
    {
        private IObjednavkaFinder of;

        public ObjednavkaService()
        {
            of = new ObjednavkaFinder();
        }

        public Collection<Objednavka> getObjednavky()
        {

            Collection<IObjednavkaGateway> ObjednavkaGateways = of.SELECT();
            Collection<Objednavka> Objednavky = new Collection<Objednavka>();
            foreach (IObjednavkaGateway og in ObjednavkaGateways)
            {
                Objednavky.Add(new Objednavka(og));
            }
            return Objednavky;

        }

        public void InsertObjednavku(Objednavka objednavka)
        {
            Objednavka o = objednavka;
            IObjednavkaGateway og=new ObjednavkaGateway();
            og.Uzivatel.Id = o.Uzivatel;

            og.Insert();

        }

        public Objednavka getIdObjednavky(int param)
        {

            IObjednavkaGateway ObjednavkaGateway = of.VyberId(param);
            Objednavka objednavka = new Objednavka(ObjednavkaGateway);

            return objednavka;

        }


    }
}
