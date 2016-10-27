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
    public class UlozeniGateway:IUlozeniGateway
    {

        public IKnihovnaGateway Knihovna
        { set; get; }
        public IPisnickaGateway Pisnicka
        { set; get; }


        public static String SQL_INSERT = "insert into Ulozeni(knihovna_id,pisnicka_id) values(@id_k,@id_p)";

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

        private void PrepareCommand(SqlCommand command  )
        {
            command.Parameters.Add(new SqlParameter("@id_k", SqlDbType.Int));
            command.Parameters["@id_k"].Value = this.Knihovna.Id;

            command.Parameters.Add(new SqlParameter("@id_p", SqlDbType.Int));
            command.Parameters["@id_p"].Value = Pisnicka.Id;
        }



    }
}
