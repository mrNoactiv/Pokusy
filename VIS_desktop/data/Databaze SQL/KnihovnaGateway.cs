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
    public class KnihovnaGateway:IKnihovnaGateway
    {
        public int Id
        { set; get; }


        public IUzivatelGateway Uzivatel
        { set; get; }

        public static String SQL_INSERT = "insert into Knihovna(uzivatel_id) values(@id_u)";

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

        private void PrepareCommand(SqlCommand command)
        {
            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = Id;

            command.Parameters.Add(new SqlParameter("@id_u", SqlDbType.Int));
            command.Parameters["@id_u"].Value = Uzivatel;
        }



    }
}
