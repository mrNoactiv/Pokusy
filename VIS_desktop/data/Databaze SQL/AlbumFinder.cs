using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Interface;

namespace VIS_desktop.Databaze
{
    public class AlbumFinder: IAlbumFinder
    {
        private  String albumSelectID = "select nazev,datumVydani,pocetPisnicek from Album where id=@id";
        private String selectAlbum = "select nazev from Album";

        private  Collection<IAlbumGateway> Read(SqlDataReader reader)
        {
            Collection<IAlbumGateway> Alba = new Collection<IAlbumGateway>();
            while (reader.Read())
            {
                IAlbumGateway Album = new AlbumGateway();
                //Album.setIdAlba(reader.GetInt32(0));
                Album.Nazev=reader.GetString(0);
                Album.DatumVydani=reader.GetDateTime(1);
                Album.PocetPisnicek=reader.GetInt32(2);
                Alba.Add(Album);
            }
            return Alba;
        }

        public IAlbumGateway SelectId(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(albumSelectID);

            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = id;
            SqlDataReader reader = db.Select(command);

            Collection<IAlbumGateway> Alba = Read(reader);
            IAlbumGateway Album = null;
            if (Alba.Count == 1)
            {
                Album = Alba[0];
            }
            reader.Close();
            db.Close();
            return Album;
        }


        private Collection<IAlbumGateway> Read2(SqlDataReader reader2)
        {
            Collection<IAlbumGateway> Alba = new Collection<IAlbumGateway>();

            while (reader2.Read())
            {
                IAlbumGateway Album = new AlbumGateway();
                Album.Nazev=reader2.GetString(0);
                Alba.Add(Album);
            }
            return Alba;
        }

        public Collection<IAlbumGateway> Select()
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(selectAlbum);
            SqlDataReader reader2 = db.Select(command);

            Collection<IAlbumGateway> Alba = Read2(reader2);
            reader2.Close();
            db.Close();
            return Alba;
        }

        
        


    




    }
}
