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
    public class HodnoceniPisnickyFinder:IHodnoceniPisnickyFinder
    {
        public static String SQL_SELECT_PISNICKA = "SELECT h.text,h.hodnoceni,u.prezdivka FROM Hodnoceni_Pisnicky h join Pisnicka p on p.ID=h.PISNICKA_ID join Uzivatel u on u.ID = h.UZIVATEL_ID where p.ID=@idTEMP";

        private Collection<IHodnoceniPisnickyGateway> Read(SqlDataReader reader)
        {
            Collection<IHodnoceniPisnickyGateway> HodnoceniKolekce = new Collection<IHodnoceniPisnickyGateway>();

            while (reader.Read())
            {
                IHodnoceniPisnickyGateway h = new HodnoceniPisnickyGateway();
                UzivatelGateway Uzivatel = new UzivatelGateway();
                h.Text = reader.GetString(0);
                h.Hodnoceni = reader.GetInt32(1);
                Uzivatel.Prezdivka = reader.GetString(2);

                h.Uzivatel = Uzivatel;

                HodnoceniKolekce.Add(h);
            }
            return HodnoceniKolekce;
        }

        public Collection<IHodnoceniPisnickyGateway> selectPisnicky(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT_PISNICKA);

            command.Parameters.Add(new SqlParameter("@idTEMP", SqlDbType.Int));
            command.Parameters["@idTEMP"].Value = id;
            SqlDataReader reader2 = db.Select(command);

            Collection<IHodnoceniPisnickyGateway> HodnoceniPisnicek = Read(reader2);

            reader2.Close();
            db.Close();
            return HodnoceniPisnicek;
        }


    }
}
