using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Diagnostics;
using TobbbformosPizzaAlkalmazasTobbTabla.Model;

namespace TobbbformosPizzaAlkalmazasTobbTabla.Repository
{
    partial class RepositoryDatabaseTableOrder
    {
        private readonly string connectionStringCreate;
        private readonly string connectionString;

        /// <summary>
        /// Konstruktor - kezdőértékadások
        /// </summary>
        public RepositoryDatabaseTableOrder()
        {
            ConnectionString cs = new ConnectionString();
            connectionStringCreate = cs.getCreateString();
            connectionString = cs.getConnectionString();
        }

        public void createTableOrder()
        {
            string queryUSE = "USE csarp;";
            string queryCreateTable ="" +
                "CREATE TABLE `prendeles` ("+
                    "`razon` int(8) NOT NULL DEFAULT '0',"+
                    "`vazon` int(6) NOT NULL DEFAULT '0',"+
                    "`fazon` int(3) NOT NULL DEFAULT '0',"+
                    "`datum` date NOT NULL DEFAULT '2017-01-01',"+
                    "`ido` float NOT NULL DEFAULT '0',"+
                    "`teljesites` tinyint(1) NOT NULL DEFAULT '0'"+
                ") ENGINE = MyISAM DEFAULT CHARSET = latin2 COLLATE = latin2_hungarian_ci; ";

            string queryPrimaryKey = "ALTER TABLE `prendeles`  ADD PRIMARY KEY(`razon`); ";

            MySqlConnection connection =
                new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand cmdUSE = new MySqlCommand(queryUSE, connection);
                cmdUSE.ExecuteNonQuery();
                MySqlCommand cmdCreateTable = new MySqlCommand(queryCreateTable, connection);
                cmdCreateTable.ExecuteNonQuery();
                MySqlCommand cmdPrimaryKey = new MySqlCommand(queryPrimaryKey, connection);
                cmdPrimaryKey.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Tábla lérehozása sikertelen.");
            }
        }

        
        public void deleteTableOrder()
        {
            string query =
                "USE csarp; " +
                "DROP TABLE prendeles;";

            MySqlConnection connection =
                new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Tábla törlése nem sikerült.");
            }
        }
        
        public void deleteDataFromTable()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Order.getSQLCommandDeleteAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Tesztadatok törlése sikertelen.");
            }
        }
    }
}
