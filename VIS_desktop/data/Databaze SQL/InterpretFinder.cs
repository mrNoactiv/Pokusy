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
    public class InterpretFinder:IInterpretFinder
    {
        public  String SQL_SELECT = "SELECT ID,umeleckejmeno FROM Interpret";
        public  String SQL_SELECT_ID = "SELECT umeleckeJmeno,jmeno,zeme,datumNarozeni FROM Interpret where ID=@id";



        private  Collection<IInterpretGateway> Read(SqlDataReader reader)
        {
            Collection<IInterpretGateway> Interpreti = new Collection<IInterpretGateway>();

            while (reader.Read())
            {
                IInterpretGateway Interpret = new InterpretGateway();
                Interpret.Id = reader.GetInt32(0);
                Interpret.UmeleckeJmeno = reader.GetString(1);



                Interpreti.Add(Interpret);
            }
            return Interpreti;
        }

        private  Collection<IInterpretGateway> Read2(SqlDataReader reader2)
        {
            Collection<IInterpretGateway> Interpreti = new Collection<IInterpretGateway>();

            while (reader2.Read())
            {
                IInterpretGateway interpret = new InterpretGateway
                {
                    UmeleckeJmeno = reader2.GetString(0),
                    Jmeno = reader2.GetString(1),
                    Zeme = reader2.GetString(2),
                    DatumNarozeni = reader2.GetDateTime(3)
                };

                Interpreti.Add(interpret);
            }
            return Interpreti;
        }


        public  Collection<IInterpretGateway> SELECT()
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            Collection<IInterpretGateway> Interpreti = Read(reader);
            reader.Close();
            db.Close();
            return Interpreti;
        }

        public  IInterpretGateway SelectId(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT_ID);

            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = id;
            SqlDataReader reader2 = db.Select(command);

            Collection<IInterpretGateway> Interpreti = Read2(reader2);
            IInterpretGateway Interpret = null;
            if (Interpreti.Count == 1)
            {
                Interpret = Interpreti[0];
            }
            reader2.Close();
            db.Close();
            return Interpret;
        }







    }
}
