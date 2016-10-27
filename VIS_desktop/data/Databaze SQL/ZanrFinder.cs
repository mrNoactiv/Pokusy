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
    public class ZanrFinder:Interface.IZanrFinder
    {
        public  String selectZanry = "select id,nazev from Zanr";
        public  String selectZanr = "select nazev,popis from zanr where id=@id";



        private  Collection<ZanrGateway> Read2(SqlDataReader reader2)
        {
            Collection<ZanrGateway> Zanry = new Collection<ZanrGateway>();

            while (reader2.Read())
            {
                ZanrGateway Zanr = new ZanrGateway();
                Zanr.Id=reader2.GetInt32(0);
                Zanr.Nazev=reader2.GetString(1);
                Zanry.Add(Zanr);
            }
            return Zanry;
        }

        public  Collection<ZanrGateway> SELECT()
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(selectZanry);
            SqlDataReader reader2 = db.Select(command);

            Collection<ZanrGateway> Zanry = Read2(reader2);
            reader2.Close();
            db.Close();
            return Zanry;
        }


        private  Collection<ZanrGateway> Read3(SqlDataReader reader3)
        {
            Collection<ZanrGateway> Zanry = new Collection<ZanrGateway>();

            while (reader3.Read())
            {
                ZanrGateway Zanr = new ZanrGateway();
                Zanr.Nazev=reader3.GetString(0);
                Zanr.Popis=reader3.GetString(1);
                Zanry.Add(Zanr);
            }
            return Zanry;
        }




        public  ZanrGateway SelectId(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(selectZanr);

            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = id;
            SqlDataReader reader3 = db.Select(command);

            Collection<ZanrGateway> Zanry = Read3(reader3);
            ZanrGateway Zanr = null;
            if (Zanry.Count == 1)
            {
                Zanr = Zanry[0];
            }
            reader3.Close();
            db.Close();
            return Zanr;
        }

        Collection<IZanrGateway> IZanrFinder.SELECT()
        {
            throw new NotImplementedException();
        }

        IZanrGateway IZanrFinder.SelectId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
