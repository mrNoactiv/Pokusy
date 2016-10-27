using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;

namespace VIS_desktop.Interface
{
    public interface IPisnickaGateway
    {
        int Id
        { set; get; }
        string Nazev
        { set; get; }
        string Delka
        { set; get; }
        float Hodnoceni
        { set; get; }

        IInterpretGateway Interpret
        { set; get; }
        IAlbumGateway Album
        { set; get; }
        IZanrGateway Zanr
        { set; get; }


        int Insert();
        int Update();
        int Delete(int id);
    }
}
