using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;

namespace VIS_desktop.Interface
{
    public interface IZanrGateway
    {
        int Insert();
        
        int Update();

         int Id
        { set; get; }
         string Nazev
        { set; get; }
         string Popis
        { set; get; }


    }
}
