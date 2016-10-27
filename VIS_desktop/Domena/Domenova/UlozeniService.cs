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
    public class UlozeniService
    {
        private IUlozeniFinder uf;


        public UlozeniService()
        {
            uf = new UlozeniFinder();
        }

        public Collection<Ulozeni> getVypisKnihovny(int id)
        {

            Collection<IUlozeniGateway> ulozeniGateways = uf.VypisKnihovny(id);
            Collection<Ulozeni> ulozeni = new Collection<Ulozeni>();
            foreach (IUlozeniGateway ug in ulozeniGateways)
            {
                ulozeni.Add(new Ulozeni(ug));
            }
            return ulozeni;

        }

        public static void InsertUlozeni(Ulozeni ulozeni)
        {
            Ulozeni u = ulozeni;
            IUlozeniGateway ug=new UlozeniGateway();
            ug.Pisnicka.Id = u.IdPisnicky;
            ug.Knihovna.Id = u.IdKnihovny;


            ug.Insert();

        }



    }
}
