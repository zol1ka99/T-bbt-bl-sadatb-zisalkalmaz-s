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
   
        public void fillOrderWithTestDataFromSQLCommand()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string query =
                    "INSERT INTO `prendeles` (`razon`, `vazon`, `fazon`, `datum`, `ido`) VALUES "+
                            "(1, 4, 2, '2010-10-01', 13.15), " +
                            "(2, 7, 2, '2010-10-01', 14.17), " +
                            "(3, 1, 1, '2010-10-02', 11.07), " +
                            "(4, 5, 2, '2010-10-02', 14.55), " +
                            "(5, 2, 3, '2010-10-02', 15.27), " +
                            "(6, 4, 2, '2010-10-03', 15.58), " +
                            "(7, 6, 2, '2010-10-04', 11.44), " +
                            "(8, 7, 4, '2010-10-04', 12.11), " +
                            "(9, 1, 5, '2010-10-04', 14.33), " +
                            "(10, 3, 5, '2010-10-04', 18.04), " +
                            "(11, 2, 1, '2010-10-05', 16.38), " +
                            "(12, 5, 2, '2010-10-05', 17.02), " +
                            "(13, 6, 2, '2010-10-06', 12.17), " +
                            "(14, 4, 3, '2010-10-06', 13.21), " +
                            "(15, 1, 4, '2010-10-06', 15.05), " +
                            "(16, 2, 5, '2010-10-06', 15.59), " +
                            "(17, 7, 2, '2010-10-06', 18.44), " +
                            "(18, 3, 2, '2010-10-07', 12.01), " +
                            "(19, 4, 5, '2010-10-07', 13.44), " +
                            "(20, 1, 1, '2010-10-07', 17.25), " +
                            "(21, 5, 3, '2010-10-08', 14.29); ";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Tesztadatok feltöltése sikertelen.");
            }
        }
    }
}
