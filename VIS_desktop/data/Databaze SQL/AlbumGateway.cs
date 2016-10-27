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
    public class AlbumGateway :IAlbumGateway
    {
        

        private static readonly string UPDATE_ALBUM= "UPDATE \"Album\" SET nazev=@nazev,pocetPisnicek=@pocetPisnicek,datumVydani=@datumVydani where id=@idA";
        private static readonly string SQL_INSERT = "INSERT INTO Album(nazev,datumVydani) VALUES (@nazev,@datumVydani)";
        private static readonly string SQL_DELETE = "Delete from Album where id=@id";

        public int Id
        { set; get; }
        public string Nazev
        { set; get; }
        public int PocetPisnicek
        { set; get; }
        public DateTime DatumVydani
        { set; get; }

        

        public int Insert()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command);

            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;

        }
        

        public int Delete()
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE);

            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = this.Id;
            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }


        private void PrepareCommand(SqlCommand command)
        {
            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = this.Id;

            command.Parameters.Add(new SqlParameter("@nazev", SqlDbType.VarChar, this.Nazev.Length));
            command.Parameters["@nazev"].Value = this.Nazev;

            command.Parameters.Add(new SqlParameter("@datumVydani", SqlDbType.Date));
            command.Parameters["@datumVydani"].Value = this.DatumVydani;


        }


        

        

       



    }



}

