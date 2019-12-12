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
    partial class RepositoryDatabaseTableItem
    {
   
        public void fillOrderWithTestDataFromSQLCommand()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string query =
                    "INSERT INTO `ptetel` (`razon`, `pazon`, `db`) VALUES " +
                            "(1, 1, 2), " +
                            "(1, 4, 3), " +
                            "(2, 2, 1), " +
                            "(3, 1, 2), " +
                            "(4, 1, 1), " +
                            "(4, 4, 1), " +
                            "(5, 2, 4), " +
                            "(6, 1, 1), " +
                            "(6, 4, 1), " +
                            "(6, 5, 1), " +
                            "(7, 5, 5), " +
                            "(8, 4, 3), " +
                            "(9, 2, 1), " +
                            "(10, 1, 1), " +
                            "(10, 4, 1), " +
                            "(11, 1, 1), " +
                            "(12, 2, 2), " +
                            "(12, 4, 2), " +
                            "(13, 4, 1), " +
                            "(13, 5, 1), " +
                            "(13, 2, 1), " +
                            "(14, 2, 2), " +
                            "(15, 1, 1), " +
                            "(16, 2, 1), " +
                            "(16, 4, 1), " +
                            "(16, 5, 1), " +
                            "(17, 1, 2), " +
                            "(17, 2, 3), " +
                            "(18, 1, 4), " +
                            "(18, 5, 1), " +
                            "(19, 1, 1), " +
                            "(19, 2, 1), " +
                            "(19, 4, 1), " +
                            "(19, 5, 1), " +
                            "(20, 5, 3), " +
                            "(21, 2, 2), " +
                            "(21, 4, 1); ";
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
