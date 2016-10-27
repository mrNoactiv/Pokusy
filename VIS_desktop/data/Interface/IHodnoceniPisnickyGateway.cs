using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;

namespace VIS_desktop.Interface
{
    public interface IHodnoceniPisnickyGateway
    {
         int Id
        { set; get; }
         string Text
        { set; get; }
         int Hodnoceni
        { set; get; }


         IUzivatelGateway Uzivatel
        { set; get; }
         IPisnickaGateway Pisnicka
        { set; get; }





        int Insert();


    }
}
