using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIS_desktop.Interface
{
    public interface IObjednavkaFinder
    {
        Collection<IObjednavkaGateway> SELECT();
        IObjednavkaGateway VyberId(int id);



    }
}
