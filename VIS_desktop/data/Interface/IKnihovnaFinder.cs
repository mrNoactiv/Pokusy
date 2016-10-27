using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIS_desktop.Interface
{
    public interface IKnihovnaFinder
    {
        IKnihovnaGateway VyberId(int id);
    }
}
