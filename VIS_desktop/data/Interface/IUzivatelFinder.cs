using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;

namespace VIS_desktop.Interface
{
    public interface IUzivatelFinder
    {
         IUzivatelGateway SelectId(int id);
         IUzivatelGateway login(string prezdivka, string heslo);
    }
}
