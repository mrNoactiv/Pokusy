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
    public class HodnoceniPisnickyService
    {
        private IHodnoceniPisnickyFinder finder;


        public HodnoceniPisnickyService()
        {
            finder = new HodnoceniPisnickyFinder();
        }

        public Collection<HodnoceniPisnicky> getPisnicky(int param)
        {

            Collection<IHodnoceniPisnickyGateway> HodnoceniGateways = finder.selectPisnicky(param);
            Collection<HodnoceniPisnicky> Hodnoceni = new Collection<HodnoceniPisnicky>();
            foreach (IHodnoceniPisnickyGateway hg in HodnoceniGateways)
            {
                Hodnoceni.Add(new HodnoceniPisnicky(hg));
            }
            return Hodnoceni;

        }

        public void InsertHodnoceni(HodnoceniPisnicky HodnoceniPisnicky, Pisnicka Pisnicka, Uzivatel Uzivatel)
        {
            HodnoceniPisnicky h = HodnoceniPisnicky;
            IHodnoceniPisnickyGateway hpg= new HodnoceniPisnickyGateway();


            IPisnickaGateway pg = new PisnickaGateway();
            IUzivatelGateway ug = new UzivatelGateway();

            Pisnicka p = Pisnicka;
            Uzivatel u = Uzivatel;

            hpg.Text = h.Text;
            hpg.Hodnoceni = h.Hodnoceni;
            hpg.Uzivatel.Id = u.Id;
            hpg.Pisnicka.Id = p.Id;

            hpg.Insert();

        }


    }
}
