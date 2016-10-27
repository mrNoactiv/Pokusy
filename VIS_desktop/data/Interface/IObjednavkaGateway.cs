using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;

namespace VIS_desktop.Interface
{
    public interface IObjednavkaGateway
    {
        int Id
        { set; get; }
        IUzivatelGateway Uzivatel
        { get; set; }

        int Insert();

    }
}
