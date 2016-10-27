using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIS_desktop.Databaze
{
    public class UzivatelGateway:Interface.IUzivatelGateway
    {
        public int Id
        { get; set; }
        public string Prezdivka
        { set; get; }

        public string Heslo
        { set; get; }

        public string Email
        { set; get; }
        public string Typ
        { set; get; }



        public  String SQL_INSERT = "INSERT INTO \"Uzivatel\" VALUES (@prezdivka,@email,@typ,@heslo)";
        public  String SQL_UPDATE = "UPDATE \"Uzivatel\" SET prezdivka=@prezdivka,heslo=@heslo,email=@email WHERE ID=@idU";

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

            command.Parameters.Add(new SqlParameter("@idU", SqlDbType.Int));
            command.Parameters["@idU"].Value = this.Id;



            PrepareCommand2(command);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }



        private  void PrepareCommand(SqlCommand command)
        {
            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = this.Id;

            command.Parameters.Add(new SqlParameter("@prezdivka", SqlDbType.VarChar, this.Prezdivka.Length));
            command.Parameters["@prezdivka"].Value = this.Prezdivka;

            command.Parameters.Add(new SqlParameter("@heslo", SqlDbType.VarChar, Heslo.Length));
            command.Parameters["@heslo"].Value = Heslo;

            command.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, Email.Length));
            command.Parameters["@email"].Value = Email;

            command.Parameters.Add(new SqlParameter("@typ", SqlDbType.VarChar, Typ.Length));
            command.Parameters["@typ"].Value = Typ;
        }

        private  void PrepareCommand2(SqlCommand command)
        {
            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = Id;

            command.Parameters.Add(new SqlParameter("@prezdivka", SqlDbType.VarChar, Prezdivka.Length));
            command.Parameters["@prezdivka"].Value = Prezdivka;

            command.Parameters.Add(new SqlParameter("@heslo", SqlDbType.VarChar, Heslo.Length));
            command.Parameters["@heslo"].Value = Heslo;

            command.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, Email.Length));
            command.Parameters["@email"].Value = Email;

            
        }

    }
}
