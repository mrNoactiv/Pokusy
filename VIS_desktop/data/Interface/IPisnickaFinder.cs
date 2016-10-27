using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;

namespace VIS_desktop.Interface
{
    public interface IPisnickaFinder
    {
        IPisnickaGateway SelectId(int id);
        Collection<IPisnickaGateway> SELECT();
        Collection<IPisnickaGateway> selectPodleAlba(string nazev);
        Collection<IPisnickaGateway> selectZanr(int id);
        void UpravHodnoceni(int id);
    }
}
