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
    public class UzivatelFinder:IUzivatelFinder
    {
        public  String SQL_SELECT_ID = "SELECT prezdivka,email,typ FROM Uzivatel where ID=@id";
        public  String SQL_login = "select id,prezdivka,typ,email from uzivatel where prezdivka=@prezdivka and heslo=@heslo";

        private  Collection<IUzivatelGateway> Read(SqlDataReader reader)
        {
            Collection<IUzivatelGateway> Uzivatele = new Collection<IUzivatelGateway>();

            while (reader.Read())
            {
                UzivatelGateway Uzivatel = new UzivatelGateway();
                Uzivatel.Prezdivka = reader.GetString(0);
                Uzivatel.Email = reader.GetString(1);
                Uzivatel.Typ = reader.GetString(2);
                

                Uzivatele.Add(Uzivatel);
            }
            return Uzivatele;
        }

        public  IUzivatelGateway SelectId(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT_ID);

            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = id;
            SqlDataReader reader = db.Select(command);

            Collection<IUzivatelGateway> Uzivatele = Read(reader);
            IUzivatelGateway Uzivatel = null;
            if (Uzivatele.Count == 1)
            {
                Uzivatel = Uzivatele[0];
            }
            reader.Close();
            db.Close();
            return Uzivatel;
        }


        private  Collection<IUzivatelGateway> ReadLogin(SqlDataReader reader)
        {
            Collection<IUzivatelGateway> Uzivatele = new Collection<IUzivatelGateway>();

            while (reader.Read())
            {
                IUzivatelGateway Uzivatel = new UzivatelGateway();

                Uzivatel.Id = reader.GetInt32(0);
                Uzivatel.Prezdivka = reader.GetString(1);
                Uzivatel.Typ = reader.GetString(2);
                Uzivatel.Email = reader.GetString(3);

                Uzivatele.Add(Uzivatel);
            }
            return Uzivatele;
        }
        
        public  IUzivatelGateway login(string prezdivka,string heslo)
        {

            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_login);

            command.Parameters.Add(new SqlParameter("@prezdivka", SqlDbType.VarChar,prezdivka.Length));
            command.Parameters["@prezdivka"].Value = prezdivka;

            command.Parameters.Add(new SqlParameter("@heslo", SqlDbType.VarChar, heslo.Length));
            command.Parameters["@heslo"].Value = heslo;

            SqlDataReader reader = db.Select(command);

            Collection<IUzivatelGateway> Uzivatele = ReadLogin(reader);
            IUzivatelGateway Uzivatel = null;
            if (Uzivatele.Count == 1)
            {
                Uzivatel = Uzivatele[0];
            }
            reader.Close();
            db.Close();
            return Uzivatel;
        }





    }
}
