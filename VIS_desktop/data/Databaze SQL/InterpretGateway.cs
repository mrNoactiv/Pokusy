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
    public class InterpretGateway:IInterpretGateway
    {
        public int Id
        { get; set; }
        public string Jmeno
        { get; set; }
        public string UmeleckeJmeno
        {
            get; set;
        }
        public string Zeme
        { get; set; }
        public DateTime DatumNarozeni
        { get; set; }



        public  String SQL_INSERT = "INSERT INTO Interpret(umeleckeJmeno,jmeno,zeme,datumNarozeni) VALUES (@pseudoJmeno,@jmeno,@zeme,@datumNarozeni)";
        //public  String SQL_UPDATE = "UPDATE \"Interpret\" SET umeleckeJmeno=@pseudoJmeno,jmeno=@jmeno,zeme=@zeme,datumNarozeni=@datumNarozeni where ID=@idI";
        public  String SQL_DELETE_ID = "Delete from interpret where id=@id";

        public int Insert()
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command);

            int ret =db.ExecuteNonQuery(command);
            db.Close();
            return ret;

        }

        public  int Delete(int id)
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


        private  void PrepareCommand(SqlCommand command)
        {
            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = Id;

            command.Parameters.Add(new SqlParameter("@pseudoJmeno", SqlDbType.VarChar, UmeleckeJmeno.Length));
            command.Parameters["@pseudoJmeno"].Value = UmeleckeJmeno;

            command.Parameters.Add(new SqlParameter("@jmeno", SqlDbType.VarChar, Jmeno.Length));
            command.Parameters["@jmeno"].Value = Jmeno;

            command.Parameters.Add(new SqlParameter("@zeme", SqlDbType.VarChar, Zeme.Length));
            command.Parameters["@zeme"].Value = Zeme;

            command.Parameters.Add(new SqlParameter("@datumNarozeni", SqlDbType.Date));
            command.Parameters["@datumNarozeni"].Value = DatumNarozeni;



        }


    }
}
