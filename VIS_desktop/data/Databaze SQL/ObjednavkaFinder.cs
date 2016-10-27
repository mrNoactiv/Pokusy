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
    public class ObjednavkaFinder:IObjednavkaFinder
    {
        public static String SQL_SELECT = "select id,uzivatel_id from objednavka";
        public static String SQL_SELECT_ID_OBJEDNAVKY = "select MAX(id) from objednavka where uzivatel_id=@id";

        public Collection<IObjednavkaGateway> SELECT()
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader2 = db.Select(command);

            Collection<IObjednavkaGateway> Objednavky = Read(reader2);
            reader2.Close();
            db.Close();
            return Objednavky;
        }

        private static Collection<IObjednavkaGateway> Read(SqlDataReader reader)
        {
            Collection<IObjednavkaGateway> Objednavky = new Collection<IObjednavkaGateway>();

            while (reader.Read())
            {
                IObjednavkaGateway Objednavka = new ObjednavkaGateway();
                IUzivatelGateway U = new UzivatelGateway();
                Objednavka.Id = reader.GetInt32(0);
                U.Id = reader.GetInt32(1);
               

                Objednavka.Uzivatel = U;

                Objednavky.Add(Objednavka);
            }
            return Objednavky;
        }




        private static Collection<IObjednavkaGateway> ReadId(SqlDataReader reader)
        {
            Collection<IObjednavkaGateway> Objednavky = new Collection<IObjednavkaGateway>();

            while (reader.Read())
            {
                IObjednavkaGateway Objednavka = new ObjednavkaGateway();
                Objednavka.Id = reader.GetInt32(0);

                Objednavky.Add(Objednavka);
            }
            return Objednavky;
        }





        public IObjednavkaGateway VyberId(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT_ID_OBJEDNAVKY);

            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = id;
            SqlDataReader reader = db.Select(command);

            Collection<IObjednavkaGateway> objednavky = ReadId(reader);
            IObjednavkaGateway obj = null;
            if (objednavky.Count == 1)
            {
                obj = objednavky[0];
            }
            reader.Close();
            db.Close();
            return obj;
        }




    }
}
