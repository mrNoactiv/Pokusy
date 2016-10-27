using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;
using VIS_desktop.Interface;

namespace VIS_desktop.Domenova
{
    public class KnihovnaService
    {
        private IKnihovnaFinder kf;

        public KnihovnaService()
        {
            kf = new KnihovnaFinder();
        }

        public void InsertKnihovnu(Knihovna knihovna)
        {
            Knihovna k = knihovna;
            IKnihovnaGateway kg=new KnihovnaGateway();

            kg.Uzivatel.Id = k.Uzivatel;

            kg.Insert();

        }

        public Knihovna getIdKnihovny(int param)
        {

            IKnihovnaGateway Gateway = kf.VyberId(param);
            Knihovna kn = new Knihovna(Gateway);

            return kn;

        }


    }
}
