using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Interface;
using VIS_desktop.Interface;

namespace VIS_desktop.Databaze
{
    public class HodnoceniPisnickyGateway:IHodnoceniPisnickyGateway
    {

        public int Id
        { set; get; }
        public string Text
        { set; get; }
        public int Hodnoceni
        { set; get; }


        public IUzivatelGateway Uzivatel
        { set; get; }
        public IPisnickaGateway Pisnicka
        { set; get; }


        public static String SQL_INSERT = "INSERT INTO Hodnoceni_Pisnicky(PISNICKA_ID,UZIVATEL_ID,text,hodnoceni) VALUES (@idPisnicky,@idUzivatele,@text,@hodnoceni)";


        public int Insert()
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command);
            int ret = db.ExecuteNonQuery(command);

            if (db == null)
            {
                db.Close();
            }

            return ret;
        }


        private void PrepareCommand(SqlCommand command)
        {


            command.Parameters.Add(new SqlParameter("@text", SqlDbType.VarChar, this.Text.Length));
            command.Parameters["@text"].Value = this.Text;

            command.Parameters.Add(new SqlParameter("@hodnoceni", SqlDbType.Int));
            command.Parameters["@hodnoceni"].Value = this.Hodnoceni;

            command.Parameters.Add(new SqlParameter("@idPisnicky", SqlDbType.Int));
            command.Parameters["@idPisnicky"].Value = Pisnicka.Id;

            command.Parameters.Add(new SqlParameter("@idUzivatele", SqlDbType.Int));
            command.Parameters["@idUzivatele"].Value = Uzivatel.Id;

        }



    }
}
