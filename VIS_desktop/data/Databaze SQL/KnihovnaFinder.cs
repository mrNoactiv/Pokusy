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
    public class KnihovnaFinder:IKnihovnaFinder
    {
        public static String SQL_ID_KNIHOVNY = "select id from knihovna where uzivatel_id = @id";


        private Collection<KnihovnaGateway> ReadId(SqlDataReader reader)
        {
            Collection<KnihovnaGateway> Knihovny = new Collection<KnihovnaGateway>();

            while (reader.Read())
            {
                KnihovnaGateway Knihovna = new KnihovnaGateway();
                Knihovna.Id = reader.GetInt32(0);

                Knihovny.Add(Knihovna);
            }
            return Knihovny;
        }





        public IKnihovnaGateway VyberId(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_ID_KNIHOVNY);

            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = id;
            SqlDataReader reader = db.Select(command);

            Collection<KnihovnaGateway> kni = ReadId(reader);
            KnihovnaGateway kn = null;
            if (kni.Count == 1)
            {
                kn = kni[0];
            }
            reader.Close();
            db.Close();
            return kn;
        }


    }
}
