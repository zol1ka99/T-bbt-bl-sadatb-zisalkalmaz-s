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
    partial class RepositoryDatabaseTableCustomer
    {
        public List<Customer> getVevoFromDatabasePvevoTable()
        {
            List<Customer> megrendelok = new List<Customer>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Customer.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr["vnev"].ToString();
                    bool goodResult = false;
                    int id = -1;
                    goodResult = int.TryParse(dr["vazon"].ToString(), out id);

                    if (goodResult)
                    {
                        string address = dr["vcim"].ToString();
                        Customer m = new Customer(id, name, address);
                        megrendelok.Add(m);
                    }

                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Vevő adatainak beolvasása az adatbázisból nem sikerült!");
            }
            return megrendelok;
        }
    }
}
