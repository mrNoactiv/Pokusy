using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;

namespace VIS_desktop.Interface
{
    public interface IAlbumGateway
    {
        int Insert();
        int Delete();
        int Id { set; get; }
        string Nazev { set; get; }
        int PocetPisnicek { set; get; }
        DateTime DatumVydani { set; get; }
    }
}
