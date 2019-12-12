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
    partial class RepositoryDatabaseTableOrder
    {
        public List<Order> getOrderFromDatabaseTable()
        {
            List<Order> orders = new List<Order>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Order.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bool goodResult = false;
                    int razon = -1;
                    goodResult = int.TryParse(dr["razon"].ToString(), out razon);
                    if (goodResult)
                    {
                        int vazon = -1;
                        goodResult = int.TryParse(dr["vazon"].ToString(), out vazon);
                        if (goodResult)
                        {
                            int fazon = -1;
                            goodResult = int.TryParse(dr["fazon"].ToString(), out fazon);
                            if (goodResult)
                            {
                                string datum = dr["fazon"].ToString();

                                double ido = -1;
                                goodResult = double.TryParse(dr["ido"].ToString(), out ido);
                                if (goodResult)
                                {

                                    Order o = new Order(razon, vazon, fazon, datum, ido);
                                    orders.Add(o);
                                }
                            }
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Megrenendelések beolvasása az adatbázisból nem sikerült!");
            }
            return orders;
        }
    }
}
