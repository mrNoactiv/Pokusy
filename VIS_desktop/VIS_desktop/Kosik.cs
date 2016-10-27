using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;

namespace VIS_desktop.Domenova
{
    class Kosik
    {
        private Collection<Pisnicka> pisnicky;
        private static Kosik instance;

        private Kosik()
        {

        }
        public static Kosik getInstance()
        {
            if (instance == null)
            {
                instance = new Kosik();
            }
            return instance;
        }

        public Collection<Pisnicka> getPisnicky()
        {
            return pisnicky;
        }

        public void setKolekciPisnicek(Collection<Pisnicka> pisnicky)
        {
            this.pisnicky = pisnicky;
        }


        public void addpisnicku(Pisnicka pisnicka)
        {
            this.pisnicky.Add(pisnicka);
        }

        public Boolean kosikExistuje()
        {
            return pisnicky != null;
        }

        public void znicitKosik()
        {
            pisnicky = null;
        }
    }
}
