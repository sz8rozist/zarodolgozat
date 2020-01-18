using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Database
{
    class CreateDatabase
    {
        ConnectionString dbc = new ConnectionString();
        private readonly string connectionString;
        private readonly string createString;
        public CreateDatabase()
        {
            connectionString = dbc.getConnectionString();
            createString = dbc.getCreateString();
        }
        public void createDataBase()
        {
            MySqlConnection con = new MySqlConnection(createString);
            try
            {
                con.Open();
                string query = "CREATE DATABASE IF NOT EXISTS `buildyourbody` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci; USE `buildyourbody`; ";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (CreateDatabaseException cde)
            {
                con.Close();
                Debug.WriteLine("Az adatbázis létrehozása sikertelen!" + cde.Message);
            }

        }
        public void createDataBaseTable()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
               
                con.Close();
            }
            catch (CreateDatabaseException cde)
            {
                con.Close();
                Debug.WriteLine("A táblák létrehozása sikertelen!" + cde.Message);
            }
        }
    }
}
