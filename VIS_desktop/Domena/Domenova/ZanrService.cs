using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;
using VIS_desktop.DatabazeXML;
using VIS_desktop.Interface;

namespace VIS_desktop.Domenova
{
    public class ZanrService
    {
        private IZanrFinder zanrFinder;

        public ZanrService()
        {
            zanrFinder = new ZanrFinder();
        }


        public Collection<Zanr> getZanry()
        {

            //Collection<ZanrGateway> ZanryGateways = new ZanrFinder().SELECT();
            Collection<IZanrGateway> ZanryGateways = zanrFinder.SELECT();
            Collection<Zanr> zanry = new Collection<Zanr>();
            foreach (IZanrGateway zg in ZanryGateways)
            {
                zanry.Add(new Zanr(zg));
            }
            return zanry;

        }

        public Zanr getZanr(int param)
        {

           // ZanrGateway zanrGateway = new ZanrFinder().SelectId(param);
            IZanrGateway zanrGateway = zanrFinder.SelectId(param);
            Zanr zanr = new Zanr(zanrGateway);

            return zanr;
        }

        public void InsertZanr(Zanr zanr)
        {
            Zanr z = zanr;
            IZanrGateway zg = new ZanrGateway();
            zg.Nazev = z.Nazev;
            zg.Popis = z.Popis;
            zg.Insert();

        }


    }
}
