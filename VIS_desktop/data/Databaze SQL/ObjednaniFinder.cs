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
    public class ObjednaniFinder:IObjednaniFinder
    {
        public static String SQL_DETAIL_OBJEDNAVKY_USER = "select o.id,p.id,p.nazev,u.id,u.email from Objednavka o join Uzivatel u on o.Uzivatel_id=u.id join objednani obj on obj.objednavka_id=o.id join pisnicka p on p.id=obj.pisnicka_id where o.id=@id";

        private static Collection<IObjednaniGateway> ReadObjednavku(SqlDataReader reader)
        {
            Collection<IObjednaniGateway> Objednani = new Collection<IObjednaniGateway>();

            while (reader.Read())
            {
                IPisnickaGateway pisnicka = new PisnickaGateway();
                IObjednavkaGateway objednavka = new ObjednavkaGateway();
                IUzivatelGateway uzivatel = new UzivatelGateway();
                IObjednaniGateway objednani=new ObjednaniGateway();

                objednavka.Id = reader.GetInt32(0);
                pisnicka.Id = reader.GetInt32(1);
                pisnicka.Nazev = reader.GetString(2);
                uzivatel.Id = reader.GetInt32(3);
                uzivatel.Email = reader.GetString(4);

                objednavka.Uzivatel = uzivatel;
                objednani.Objednavka = objednavka;
                objednani.Pisnicka = pisnicka;



                Objednani.Add(objednani);


            }
            return Objednani;
        }

        public Collection<IObjednaniGateway> DetailObjednavky(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DETAIL_OBJEDNAVKY_USER);

            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = id;
            SqlDataReader reader = db.Select(command);

            Collection<IObjednaniGateway> Objednani = ReadObjednavku(reader);

            reader.Close();
            db.Close();
            return Objednani;
        }



    }
}
