using System;
using MySql.Data.MySqlClient;

namespace AppleStore.Entities
{
    public class DBContext
    {
        public static MySqlConnection CreateConnection(string connectionString)
        {
            var connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}