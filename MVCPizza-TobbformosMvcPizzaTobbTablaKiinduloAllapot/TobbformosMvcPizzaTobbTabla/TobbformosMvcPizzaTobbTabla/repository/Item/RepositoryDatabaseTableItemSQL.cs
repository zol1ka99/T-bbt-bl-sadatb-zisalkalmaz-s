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
        public List<Item> getItemFromDatabaseTable()
        {
            List<Item> items = new List<Item>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Item.getSQLCommandGetAllRecord();
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
                        int pazon = -1;
                        goodResult = int.TryParse(dr["pazon"].ToString(), out pazon);
                        if (goodResult)
                        {
                            int db = -1;
                            goodResult = int.TryParse(dr["db"].ToString(), out db);
                            if (goodResult)
                            {

                                    Item i = new Item(razon, pazon, db);
                                    items.Add(i);
                                
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
                throw new RepositoryException("Tételek beolvasása az adatbázisból nem sikerült!");
            }
            return items;
        }
    }
}
