using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TobbbformosPizzaAlkalmazasTobbTabla.Model;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace TobbbformosPizzaAlkalmazasTobbTabla.Repository
{
    partial class RepositoryDatabaseTableCourier
    {
        public List<Courier> getFutarFromDatabaseTable()
        {
            List<Courier> futarok = new List<Courier>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Courier.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bool goodResult = false;
                    string name = dr["fnev"].ToString();
                    int id = -1;
                    goodResult = int.TryParse(dr["fazon"].ToString(), out id);
                    if (goodResult)
                    {
                        string tel = dr["ftel"].ToString();
                        if (goodResult)
                        {
                            Courier f = new Courier(id, name, tel);
                            futarok.Add(f);
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Futar adatok beolvasása az adatbázisból nem sikerült!");
            }
            return futarok;
        }
    }
}
