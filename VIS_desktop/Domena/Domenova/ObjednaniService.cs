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
    public class ObjednaniService
    {
        private IObjednaniFinder of;

        public ObjednaniService()
        {
            of = new ObjednaniFinder();
        }

        public Collection<Objednani> getObjednavku(int id)
        {

            Collection<IObjednaniGateway> objednaniGateways = of.DetailObjednavky(id);
            Collection<Objednani> objednani = new Collection<Objednani>();
            foreach (IObjednaniGateway og in objednaniGateways)
            {
                objednani.Add(new Objednani(og));
            }
            return objednani;

        }


        public void InsertObjednani(Objednani objednani)
        {
            Objednani o = objednani;
            IObjednaniGateway obj=new ObjednaniGateway();

            obj.Pisnicka.Id = o.Pisnicka;
            obj.Objednavka.Id = o.Objednavka;
            

            obj.Insert();

        }


    }
}
