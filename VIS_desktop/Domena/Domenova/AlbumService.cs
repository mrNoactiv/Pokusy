using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;
using VIS_desktop.DatabazeXML;
using VIS_desktop.Interface;

namespace VIS_desktop.Domenova
{
    public class AlbumService
    {
        private IAlbumFinder albumFinder;

        public AlbumService()
        {
            albumFinder = new XmlAlbumFinder();
        }

        public Collection<Album> getAlbums()
        {

            //Collection<AlbumGateway> albumGateways = new AlbumFinder().Select();
            Collection<IAlbumGateway> albumGateways = albumFinder.Select();
            Collection<Album> albums = new Collection<Album>();
            foreach(IAlbumGateway ag in albumGateways)
            {
                albums.Add(new Album(ag));
            }
            return albums;

        }
        public Album getAlbum()
        {
            IAlbumGateway albumGateway = albumFinder.SelectId(5);
            Album album = new Album(albumGateway);
            return album;
        }

        public void InsertAlbum(Album album)
        {
            Album a = album;
            //IAlbumGateway ag = new AlbumGateway();
            IAlbumGateway xag = new AlbumGateway();

            xag.Nazev = a.Nazev;
            xag.DatumVydani = a.DatumVydani;


            //ag.Insert();
            xag.Insert();
        }

        

    }
}
