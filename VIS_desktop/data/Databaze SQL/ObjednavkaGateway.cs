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
    public class ObjednavkaGateway:IObjednavkaGateway
    {
        public int Id
        { set; get; }
        public IUzivatelGateway Uzivatel
        { get; set; }



        public static String SQL_INSERT = "insert into Objednavka(Uzivatel_id) values(@id)";

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
            command.Parameters["@id"].Value = Uzivatel;
        }



    }
}
