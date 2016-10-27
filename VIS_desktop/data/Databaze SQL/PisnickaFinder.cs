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
    public class PisnickaFinder:IPisnickaFinder
    {
        public  String selectPisnickaId= "select p.nazev,p.delka,p.hodnoceni,i.umeleckeJmeno,a.nazev,z.nazev,p.id from Pisnicka p  join Album a on a.ID=p.ALBUM_ID join Zanr z on z.ID=p.ZANR_ID join Interpret i on i.ID=p.INTERPRET_ID where p.id=@id";
        public  String selectPisnicky  = "select id,nazev from PISNICKA";
        public  String SQL_SELECT_FILTR_ALBUM = "select p.id,p.nazev,p.delka,i.umeleckeJmeno,a.nazev,a.id from pisnicka p join album a on a.ID=p.ALBUM_ID join Interpret i on i.ID=p.INTERPRET_ID where a.nazev =@nazevA";



        public  Collection<IPisnickaGateway> Read(SqlDataReader reader)
        {
            Collection<IPisnickaGateway> Pisnicky = new Collection<IPisnickaGateway>();

            while (reader.Read())
            {
                IPisnickaGateway p = new PisnickaGateway();
                IZanrGateway z = new ZanrGateway();
                IAlbumGateway a = new AlbumGateway();
                IInterpretGateway i = new InterpretGateway();

                p.Nazev=reader.GetString(0);
                p.Delka=reader.GetString(1);
                p.Hodnoceni=reader.GetFloat(2);
                i.UmeleckeJmeno=reader.GetString(3);
                a.Nazev=reader.GetString(4);
                z.Nazev=reader.GetString(5);
                p.Id = reader.GetInt32(6);

                p.Zanr = z;
                p.Album = a;
                p.Interpret = i;

                Pisnicky.Add(p);
            }
            return Pisnicky;
        }



        public  IPisnickaGateway SelectId(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(selectPisnickaId);

            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = id;
            SqlDataReader reader = db.Select(command);

            Collection<IPisnickaGateway> Pisnicky = Read(reader);
            IPisnickaGateway Pisnicka = null;
            if (Pisnicky.Count == 1)
            {
                Pisnicka = Pisnicky[0];
            }
            reader.Close();
            db.Close();
            return Pisnicka;
        }


        public  Collection<IPisnickaGateway> Read2(SqlDataReader reader)
        {
            Collection<IPisnickaGateway> Pisnicky = new Collection<IPisnickaGateway>();

            while (reader.Read())
            {
                IPisnickaGateway p = new PisnickaGateway();
                p.Id=reader.GetInt32(0);
                p.Nazev=reader.GetString(1);


                Pisnicky.Add(p);
            }
            return Pisnicky;
        }

        public  Collection<IPisnickaGateway> SELECT()
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(selectPisnicky);
            SqlDataReader reader2 = db.Select(command);

            Collection<IPisnickaGateway> Pisnicky = Read2(reader2);
            reader2.Close();
            db.Close();
            return Pisnicky;
        }

        public  Collection<IPisnickaGateway> ReadFiltrAlbum(SqlDataReader reader)
        {
            Collection<IPisnickaGateway> Pisnicky = new Collection<IPisnickaGateway>();

            while (reader.Read())
            {
                IPisnickaGateway p = new PisnickaGateway();
                IAlbumGateway a = new AlbumGateway();
                IInterpretGateway i = new InterpretGateway();

                p.Id=reader.GetInt32(0);
                p.Nazev=reader.GetString(1);
                p.Delka=reader.GetString(2);
                i.UmeleckeJmeno=reader.GetString(3);
                a.Nazev=reader.GetString(4);
                a.Id=reader.GetInt32(5);

                p.Album = a;
                p.Interpret = i;

                Pisnicky.Add(p);
            }
            return Pisnicky;
        }

        public  Collection<IPisnickaGateway> selectPodleAlba(string nazev)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT_FILTR_ALBUM);

            command.Parameters.Add(new SqlParameter("@nazevA", SqlDbType.VarChar, nazev.Length));
            command.Parameters["@nazevA"].Value = nazev;
            SqlDataReader reader = db.Select(command);

            Collection<IPisnickaGateway> Pisnicky = ReadFiltrAlbum(reader);

            reader.Close();
            db.Close();
            return Pisnicky;
        }


        public  Collection<IPisnickaGateway> ReadFiltrZanr(SqlDataReader reader)
        {
            Collection<IPisnickaGateway> Pisnicky = new Collection<IPisnickaGateway>();

            while (reader.Read())
            {
                IPisnickaGateway p = new PisnickaGateway();
                IZanrGateway z = new ZanrGateway();

                p.Id=reader.GetInt32(0);
                p.Nazev=reader.GetString(1);


                p.Zanr = z;

                Pisnicky.Add(p);
            }
            return Pisnicky;
        }




        public  Collection<IPisnickaGateway> selectZanr(int id)
        {
            Database db = new Database();
            db.Connect();

            SqlCommand cmd = db.CreateCommand("filtrZanr");
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@p_id", SqlDbType.Int);
            parm.Value = id;
            parm.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(parm);


            SqlDataReader reader = db.Select(cmd);

            Collection<IPisnickaGateway> p = ReadFiltrZanr(reader);

            reader.Close();
            db.Close();
            return p;
        }

        public void UpravHodnoceni(int id)
        {
            Database db = new Database();
            db.Connect();

            SqlCommand cmd = db.CreateCommand("HodnoceniPisnicek");
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@p_id", SqlDbType.Int);
            parm.Value = id;
            parm.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(parm);
            
            try
            {
                int ret = db.ExecuteNonQuery(cmd);
            }
            catch
            {
                Console.WriteLine("neplatne ide pisnicky");
            }
            db.Close();
        }






    }
}
