using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;

namespace VIS_desktop.Interface
{
    public interface IInterpretGateway
    {
        int Id
        { get; set; }
        string Jmeno
        { get; set; }
        string UmeleckeJmeno
        {
            get; set;
        }
        string Zeme
        { get; set; }
        DateTime DatumNarozeni
        { get; set; }


        int Insert();
        int Delete(int id);
    }
}
