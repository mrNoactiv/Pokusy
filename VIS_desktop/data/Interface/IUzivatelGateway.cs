using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;

namespace VIS_desktop.Interface
{
    public interface IUzivatelGateway
    {
         int Id
        { get; set; }
         string Prezdivka
        { set; get; }

        string Heslo
        { set; get; }

        string Email
        { set; get; }
        string Typ
        { set; get; }


        int Insert();

        int Update();


    }
}
