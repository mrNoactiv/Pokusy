using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Interface;

namespace VIS_desktop.Databaze
{
    public class PisnickaGateway:Interface.IPisnickaGateway
    {
        public int Id
        { set; get; }
        public string Nazev
        { set; get; }
        public string Delka
        { set; get; }
        public float Hodnoceni
        { set; get; }

        public IInterpretGateway Interpret
        { set; get; }
        public IAlbumGateway Album
        { set; get; }
        public IZanrGateway Zanr
        { set; get; }

        public  String SQL_INSERT = "INSERT INTO \"Pisnicka\"(nazev,INTERPRET_ID,delka,ZANR_ID,ALBUM_ID) VALUES (@nazev,@idInterpreta,@delka,@idZanr,@idAlbum)";
        public  String SQL_UPDATE = "UPDATE \"Pisnicka\" SET nazev=@nazev,delka=@delka where ID=@idP";
        public  String SQL_DELETE_ID = "DELETE FROM \"Pisnicka\" WHERE ID=@id";

       

        public  int Insert()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command);
            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }



        public  int Update()
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);

            command.Parameters.Add(new SqlParameter("@idP", SqlDbType.Int));
            command.Parameters["@idP"].Value = Id;

            PrepareCommandUpdate(command );
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public int Delete(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE_ID);

            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = id;
            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }



        private  void PrepareCommandUpdate(SqlCommand command)
        {

            command.Parameters.Add(new SqlParameter("@nazev", SqlDbType.VarChar, Nazev.Length));
            command.Parameters["@nazev"].Value = Nazev;

            command.Parameters.Add(new SqlParameter("@delka", SqlDbType.VarChar, Delka.Length));
            command.Parameters["@delka"].Value = Delka;

        }

        private  void PrepareCommand(SqlCommand command)
        {
            // command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            // command.Parameters["@id"].Value = Pisnicka.IdPisnicky;

            command.Parameters.Add(new SqlParameter("@nazev", SqlDbType.VarChar, Nazev.Length));
            command.Parameters["@nazev"].Value = Nazev;

            command.Parameters.Add(new SqlParameter("@idInterpreta", SqlDbType.Int));
            command.Parameters["@idInterpreta"].Value = Interpret.Id;

            command.Parameters.Add(new SqlParameter("@delka", SqlDbType.VarChar, Delka.Length));
            command.Parameters["@delka"].Value = Delka;

            command.Parameters.Add(new SqlParameter("@idZanr", SqlDbType.Int));
            command.Parameters["@idZanr"].Value = Zanr.Id;

            command.Parameters.Add(new SqlParameter("@idAlbum", SqlDbType.Int));
            command.Parameters["@idAlbum"].Value = Album.Id;
        }





    }
}
