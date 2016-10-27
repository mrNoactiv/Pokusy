using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIS_desktop.Databaze
{
    public class ZanrGateway:Interface.IZanrGateway
    {
        public int Id
        { set; get; }
        public string Nazev
        { set; get; }
        public string Popis
        { set; get; }

     
        

        public  String SQL_INSERT = "INSERT INTO \"Zanr\" VALUES (@nazev,@popis)";
        public  String SQL_UPDATE = "UPDATE \"Zanr\" SET nazev=@jmeno, popis=@popis where ID=@idZ";



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

            command.Parameters.Add(new SqlParameter("@idZ", SqlDbType.Int));
            command.Parameters["@idZ"].Value = Id;

            PrepareCommand(command);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        private  void PrepareCommand(SqlCommand command)
        {
            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = Id;

            command.Parameters.Add(new SqlParameter("@nazev", SqlDbType.VarChar, Nazev.Length));
            command.Parameters["@nazev"].Value = Nazev;

            command.Parameters.Add(new SqlParameter("@popis", SqlDbType.VarChar, Popis.Length));
            command.Parameters["@popis"].Value = Popis;

        }


    }
}
