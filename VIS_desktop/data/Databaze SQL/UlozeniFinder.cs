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
    public class UlozeniFinder:IUlozeniFinder
    {
        public static String SQL_VYPIS_KNIHOVNY = "select p.id,p.nazev,k.id,u.id from knihovna k join ulozeni ul on k.id=ul.knihovna_id join uzivatel u on u.id=k.uzivatel_id join pisnicka p on p.id=ul.pisnicka_id where u.id=@id";


        private Collection<IUlozeniGateway> ReadKnihovna(SqlDataReader reader)
        {
            Collection<IUlozeniGateway> uloziste = new Collection<IUlozeniGateway>();

            while (reader.Read())
            {
                IPisnickaGateway pisnicka = new PisnickaGateway();
                IKnihovnaGateway knihovna = new KnihovnaGateway();
                IUzivatelGateway uzivatel = new UzivatelGateway();
                IUlozeniGateway ulozeni = new UlozeniGateway();

                pisnicka.Id=reader.GetInt32(0);
                pisnicka.Nazev=reader.GetString(1);
                knihovna.Id = reader.GetInt32(2);
                uzivatel.Id = reader.GetInt32(3);

                knihovna.Uzivatel = uzivatel;
                ulozeni.Knihovna = knihovna;
                ulozeni.Pisnicka = pisnicka;


                uloziste.Add(ulozeni);


            }
            return uloziste;
        }


        public Collection<IUlozeniGateway> VypisKnihovny(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_VYPIS_KNIHOVNY);

            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = id;
            SqlDataReader reader = db.Select(command);

            Collection<IUlozeniGateway> Uloziste = ReadKnihovna(reader);

            reader.Close();
            db.Close();
            return Uloziste;
        }





    }
}
