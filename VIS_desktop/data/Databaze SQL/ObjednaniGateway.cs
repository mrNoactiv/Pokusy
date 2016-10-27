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
    public class ObjednaniGateway:IObjednaniGateway
    {
        public IPisnickaGateway Pisnicka
        { get; set; }
        public IObjednavkaGateway Objednavka
        { get; set; }




        public static String SQL_INSERT = "insert into objednani(pisnicka_id,objednavka_id) values(@id_p,@id_ob)";

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
            command.Parameters.Add(new SqlParameter("@id_p", SqlDbType.Int));
            command.Parameters["@id_p"].Value = Pisnicka;

            command.Parameters.Add(new SqlParameter("@id_ob", SqlDbType.Int));
            command.Parameters["@id_ob"].Value = Objednavka;
        }



    }
}
